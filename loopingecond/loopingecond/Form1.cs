<<<<<<< HEAD:evelyn/loopingecond/loopingecond/Form1.cs
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopingecond
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void combustívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcomb combustivel = new frmcomb();
            combustivel.Show();
            this.Hide();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmloop looping = new frmloop();
            looping.Show();
            this.Hide();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopingecond
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void combustívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcomb combustivel = new frmcomb();
            combustivel.Show();
            this.Hide();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
>>>>>>> d4c64029224b362e64ea13f6a78aecbe7b1ed521:loopingecond/loopingecond/Form1.cs
