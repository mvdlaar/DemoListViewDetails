using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoListViewDetails
{
    public partial class ListviewDemoDetailsForm : Form
    {
        public ListviewDemoDetailsForm()
        {
            InitializeComponent();
        }

        private void btVoegRijToe_Click(object sender, EventArgs e)
        {
            string tekst = "item " + (lvDemoListview.Items.Count + 1).ToString();
            
            ListViewItem lvi = new ListViewItem(tekst);

            for (int i = 1; i <= 3; i++)
            {
                lvi.SubItems.Add("subitem " + i);
            }
            lvDemoListview.Items.Add(lvi);
        }
    }
}
