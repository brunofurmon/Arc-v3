using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
