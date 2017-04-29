using Arc.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arc
{
    public partial class ArcWindow : Form
    {
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
            this.StatusLabel.Text = "Processando";

            DataTable dataTable = ExcelService.CreateDataTableFromExcelFile(filename);
            this.dataGridView.DataSource = dataTable;

            this.FilenameLabel.Text = filename;
            this.LineCountLabel.Text = dataTable.Rows.Count.ToString();

            this.StatusLabel.Text = "Pronto";
        }

        private void CloseFile()
        {
            this.StatusLabel.Text = "Fechando arquivo";

            this.dataGridView.DataSource = new {};

            this.FilenameLabel.ResetText();
            this.LineCountLabel.ResetText();

            this.StatusLabel.Text = "Pronto";
        }
    }
}
