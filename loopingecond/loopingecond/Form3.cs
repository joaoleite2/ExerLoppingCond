using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopingecond
{
    public partial class frmloop : Form
    {
        public frmloop()
        {
            InitializeComponent();
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            int num, result, i;
            num = Convert.ToInt32(txtdigite.Text);
            i = 0;
            do
            {
               
                result = num * i;
               
                txttabuada.Text = String.Concat(txttabuada.Text, "\r\n", result.ToString());

                i++;
            } while (i <= 10);
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            double num, result;
            int i;
            num = Convert.ToInt32(txtdigite.Text);

            i = 0;
            while (i <= 10) {
                result = num * i;
                txttabuada.Text = String.Concat(txttabuada.Text, "\r\n", result.ToString());
                i++;
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdigite.Clear();
            txttabuada.Clear();
            txtdigite.Focus();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int i, num, result;
            num = Convert.ToInt32(txtdigite.Text);

            for (i = 0; i <=10; i++)
            {
                result = num * i;
                txttabuada.Text = String.Concat(txttabuada.Text, "\r\n", result.ToString());
            }
        }
    }
}
