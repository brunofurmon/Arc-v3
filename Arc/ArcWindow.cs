using Arc.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Arc.Services.ArcConstants;


namespace Arc
{
    public partial class ArcWindow : Form
    {
        public string CurrentFilename { get; private set; }

        public ArcWindow()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop))?
                DragDropEffects.All :
                DragDropEffects.None;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
                // One message only!
                if (files.Count() == 1)
                {
                    OpenExcelFile(files[0]);
                }
            }
        }

        private void FecharArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void OpenExcelFile(string filename)
        {
            // Closes any file opened before
            CloseFile();

            this.StatusLabel.Text = "Processando";
            this.CurrentFilename = filename;

            DataTable dataTable = ExcelService.CreateDataTableFromExcelFile(filename);
            this.dataGridView.DataSource = dataTable;

            this.FilenameLabel.Text = filename;
            this.LineCountLabel.Text = dataTable.Rows.Count.ToString();

            this.RenameButton.Enabled = true;
            this.StatusLabel.Text = "Pronto";
        }

        private void CloseFile()
        {
            this.StatusLabel.Text = "Fechando arquivo";
            this.CurrentFilename = "";

            this.RenameButton.Enabled = false;
            this.dataGridView.DataSource = new {};

            this.FilenameLabel.ResetText();
            this.LineCountLabel.ResetText();

            this.StatusLabel.Text = "Pronto";
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            this.StatusLabel.Text = "Renomeando";
            this.RenameButton.Enabled = false;
            List<Tuple<string, string, bool, string>> filesRenamed = new List<Tuple<string, string, bool, string>>();
            // Read lines from dataSource
            DataGridViewRowCollection source = this.dataGridView.Rows;

            string filePath = Path.GetDirectoryName(this.CurrentFilename);
            string[] availableFilenames = Directory.GetFiles(filePath, "*.jp*");
            foreach (DataGridViewRow row in source)
            {
                DataGridViewCellCollection cells = row.Cells;
                // Read columns data
                string photoOrderStr = cells[(int)ColumnsMap.PHOTO_ORDER].FormattedValue.ToString().PadLeft(4, '0');
                // Depends on 
                string sequentialStr = cells[(int)ColumnsMap.SEQUENTIAL_NUMBER].FormattedValue.ToString().PadLeft(3, '0');
                string addressStr = cells[(int)ColumnsMap.ADDRESS].FormattedValue.ToString();

                // Removes bad characters from addressStr
                addressStr = Path.GetInvalidFileNameChars()
                    .Aggregate(addressStr, (current, c) => current.Replace(c.ToString(), "-"))
                    .Trim(' ', '\n', '\t', '\r');

                // Find file in list
                string oldFilename = availableFilenames.FirstOrDefault(name => name.Contains(photoOrderStr));

                string newFilename = string.Format("{0}\\{1} - {2}.jpg", filePath, sequentialStr, addressStr);
                // Windows only accepts 260 characters on fully qualified filenames
                newFilename = newFilename.Substring(0, Math.Min(newFilename.Length, 259));

                // Renaming
                try
                {

                    File.Move(oldFilename, newFilename);

                    filesRenamed.Add(Tuple.Create(oldFilename, newFilename, true, string.Empty));
                }
                catch (Exception ex)
                {
                    filesRenamed.Add(Tuple.Create(oldFilename, newFilename, false, ex.Message));
                }
            }
            ShowStatisticsDialog(filesRenamed);
            this.StatusLabel.Text = "Pronto";
            this.RenameButton.Enabled = true;
        }

        private void ShowStatisticsDialog(List<Tuple<string, string, bool, string>> filesRenamed)
        {
            Form statisticsBox = new StatisticsBox(filesRenamed);
            statisticsBox.Show();
        }
    }
}
