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
            
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int i, num, result;
            num = Convert.ToInt32(txtdigite.Text);

            i = 1;
            while(i<=num)
            {
                result = num * i;
                i++;
                txttabuada.Text = String.Concat(txttabuada.Text, "\r\n", result.ToString());

            }
        }
    }
}
