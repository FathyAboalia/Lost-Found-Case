using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lost_and_Found_Items
{
    public partial class SearchForLostItem2 : Form
    {
        public SearchForLostItem2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForLostItem Search = new SearchForLostItem();
            Search.ShowDialog();
        }
    }
}
