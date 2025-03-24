using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XKsTOR
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
            this.searchmode.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(searchmode_SelectedIndexChanged);
        }

        private void searchmode_SelectedIndexChanged(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < searchmode.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        searchmode.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
