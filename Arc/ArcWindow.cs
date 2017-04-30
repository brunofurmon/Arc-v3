using Arc.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        #region Events
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
# endregion Events

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
            List<Tuple<string, string>> filesRenamed = new List<Tuple<string, string>>();
            // Read lines from dataSource
            DataGridViewRowCollection source = this.dataGridView.Rows;

            // Get Filename Rename Selection
            RadioButton checkedButton =
                this.RadioButtonsPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string checkedMask = checkedButton.Text;

            string filePath = Path.GetDirectoryName(this.CurrentFilename);

            foreach (DataGridViewRow row in source)
            {
                DataGridViewCellCollection cells = row.Cells;
                // Read columns data
                string photoOrderStr = (string)cells[(int)ColumnsMap.PHOTO_ORDER].FormattedValue;
                string sequentialStr = (string)cells[(int)ColumnsMap.SEQUENTIAL_NUMBER].FormattedValue;
                string addressStr = (string)cells[(int)ColumnsMap.ADDRESS].FormattedValue;

                Debug.WriteLine(string.Format("{0} : {1} - {2}", photoOrderStr, sequentialStr, addressStr));

                //Get sourceDirectory
                try
                {
                    // "PLEASE, THINK OF SOMETHING BETTER" - You in the future.
                    int digits = checkedMask.Count(c => c == 'X');
                    string paddedPhotoOrderStr = photoOrderStr.PadLeft(digits, '0');
                    string prefix = checkedMask.Remove(checkedMask.Length - digits);
                    string resolutionString = "(1024x683)";
                    string oldFilename = string.Format("{0}\\{1}{2} {3}.jpg", filePath, prefix, paddedPhotoOrderStr, resolutionString);

                    string newFilename = string.Format("{0}\\{1} - {2}.jpg", filePath, sequentialStr, addressStr);
                    // Windows only accepts 260 characters on fully qualified filenames
                    newFilename = newFilename.Substring(0, Math.Min(addressStr.Length, 259));
                    File.Move(oldFilename, newFilename);

                    filesRenamed.Add(Tuple.Create(oldFilename, newFilename));
                }
                catch (Exception ex)
                {
                    //throw;
                }
            }
            // If file exists, rename it 
            // Count number of renamed file
            // in case of error, tell user in Result dialog box
        }
    }
}
