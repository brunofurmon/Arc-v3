using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Arc
{
    public partial class StatisticsBox : Form
    {
        public StatisticsBox()
        {
            InitializeComponent();
        }

        public StatisticsBox(List<Tuple<string, string, bool, string>> filesRenamed): this()
        {
            int total = filesRenamed.Count;
            int successNumber = filesRenamed.Count(f => f.Item3 == true);
            int failureNumber = filesRenamed.Count(f => f.Item3 == false);
            this.SuccessLabel.Text = string.Format("{0} / {1}", successNumber, total);
            this.FailureLabel.Text = string.Format("{0} / {1}", failureNumber, total);

            DataTable errorDataTable = new DataTable();
            errorDataTable.Columns.Add("Origem", typeof(string));
            errorDataTable.Columns.Add("Destino", typeof(string));
            errorDataTable.Columns.Add("Erro", typeof(string));

            foreach (Tuple<string, string, bool, string> error in filesRenamed.Where(f => f.Item3 == false))
            {
                errorDataTable.Rows.Add(error.Item1, error.Item2, error.Item4);
            }

            this.errorTable.DataSource = errorDataTable;
        }
    }
}
