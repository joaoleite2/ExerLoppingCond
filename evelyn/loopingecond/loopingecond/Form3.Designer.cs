namespace loopingecond
{
    partial class frmloop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lbldigite = new System.Windows.Forms.Label();
            this.lbltabuada = new System.Windows.Forms.Label();
            this.txtdigite = new System.Windows.Forms.TextBox();
            this.txttabuada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(259, 372);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(87, 49);
            this.btndowhile.TabIndex = 0;
            this.btndowhile.Text = "DoWhile";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(370, 372);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(87, 49);
            this.btnwhile.TabIndex = 1;
            this.btnwhile.Text = "While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(476, 372);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(87, 49);
            this.btnfor.TabIndex = 2;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(653, 322);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(87, 49);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(68, 372);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(87, 49);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // lbldigite
            // 
            this.lbldigite.AutoSize = true;
            this.lbldigite.Location = new System.Drawing.Point(99, 109);
            this.lbldigite.Name = "lbldigite";
            this.lbldigite.Size = new System.Drawing.Size(89, 13);
            this.lbldigite.TabIndex = 5;
            this.lbldigite.Text = "Digite um número";
            // 
            // lbltabuada
            // 
            this.lbltabuada.AutoSize = true;
            this.lbltabuada.Location = new System.Drawing.Point(99, 209);
            this.lbltabuada.Name = "lbltabuada";
            this.lbltabuada.Size = new System.Drawing.Size(50, 13);
            this.lbltabuada.TabIndex = 6;
            this.lbltabuada.Text = "Tabuada";
            // 
            // txtdigite
            // 
            this.txtdigite.Location = new System.Drawing.Point(303, 102);
            this.txtdigite.Name = "txtdigite";
            this.txtdigite.Size = new System.Drawing.Size(100, 20);
            this.txtdigite.TabIndex = 7;
            // 
            // txttabuada
            // 
            this.txttabuada.Location = new System.Drawing.Point(303, 202);
            this.txttabuada.Multiline = true;
            this.txttabuada.Name = "txttabuada";
            this.txttabuada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txttabuada.Size = new System.Drawing.Size(250, 20);
            this.txttabuada.TabIndex = 8;
            // 
            // frmloop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttabuada);
            this.Controls.Add(this.txtdigite);
            this.Controls.Add(this.lbltabuada);
            this.Controls.Add(this.lbldigite);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.btndowhile);
            this.Name = "frmloop";
            this.Text = "looping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lbldigite;
        private System.Windows.Forms.Label lbltabuada;
        private System.Windows.Forms.TextBox txtdigite;
        private System.Windows.Forms.TextBox txttabuada;
    }
}