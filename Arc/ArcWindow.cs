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
                    // TODO: Extract to Control Method Class inside Form
                    this.StatusLabel.Text = "Processando";
                    // Tenta abrir arquivo Excel
                    DataTable dataTable = ExcelService.CreateDataTableFromExcelFile(files[0]);
                    this.dataGridView.DataSource = dataTable;
                }
            }
        }
    }
}
