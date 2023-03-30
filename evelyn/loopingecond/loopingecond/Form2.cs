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
    public partial class frmcomb : Form
    {
        public frmcomb()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblli_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l, result;
            char cod;

            l = Convert.ToDouble(txtli.Text);
            cod = Convert.ToChar(txtcod.Text);

            if (cod.Equals("A"))
            {
                if (l <= 20)
                {
                    result = (l * 4.30);
                    txtpreco.Text = result.ToString();
                }
                else
                {
                    result = l * (4.30 - (4.30 * 5 / 100));
                    txtpreco.Text = result.ToString();
                }
            }
            else if (cod.Equals("G"))
            {
                if (l <= 20)
                {
                    result = l * (5.50 - (5.50 * 4 / 100));
                    txtpreco.Text = result.ToString();
                }
                else
                {
                    result = l * (5.50 - (5.50 * 6 / 100));
                    txtpreco.Text = result.ToString();
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtli.Clear();
            txtpreco.Clear();

            txtcod.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }

     

        private void btncalc_Click(object sender, EventArgs e)
        {
            double l, result;
            char cod;

            l = Convert.ToDouble(txtli.Text);
            cod = Convert.ToChar(txtcod.Text);

            if (cod == 'A')
            {
                if (l <= 20)
                {
                    result = l * (4.30 - (4.30 * 3 / 100));
                    txtpreco.Text = result.ToString();
                }
                else
                {
                    result = l * (4.30 - (4.30 * 5 / 100));
                    txtpreco.Text = result.ToString();
                }
            }
            else if (cod == 'G')
            {
                if (l <= 20)
                {
                    result = l * (5.50 - (5.50 * 4 / 100));
                    txtpreco.Text = result.ToString();
                }
                else
                {
                    result = l * (5.50 - (5.50 * 6 / 100));
                    txtpreco.Text = result.ToString();
                }
            }
        }
    }
}
