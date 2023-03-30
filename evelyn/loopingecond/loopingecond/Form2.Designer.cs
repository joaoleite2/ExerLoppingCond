namespace loopingecond
{
    partial class frmcomb
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
            this.lblcod = new System.Windows.Forms.Label();
            this.lblli = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtli = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(65, 104);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(265, 13);
            this.lblcod.TabIndex = 0;
            this.lblcod.Text = "Digite A se o combustível for alcool e G se for gasolina";
            // 
            // lblli
            // 
            this.lblli.AutoSize = true;
            this.lblli.Location = new System.Drawing.Point(65, 149);
            this.lblli.Name = "lblli";
            this.lblli.Size = new System.Drawing.Size(129, 13);
            this.lblli.TabIndex = 1;
            this.lblli.Text = "Digite quantidade de litros";
            this.lblli.Click += new System.EventHandler(this.lblli_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(65, 244);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(35, 13);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Preço";
            this.lblresult.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(336, 237);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 3;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(336, 97);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 1;
            // 
            // txtli
            // 
            this.txtli.Location = new System.Drawing.Point(336, 142);
            this.txtli.Name = "txtli";
            this.txtli.Size = new System.Drawing.Size(100, 20);
            this.txtli.TabIndex = 2;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(170, 340);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(81, 37);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(355, 340);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(81, 37);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(44, 341);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(77, 36);
            this.btncalc.TabIndex = 10;
            this.btncalc.Text = "button1";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // frmcomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtli);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblli);
            this.Controls.Add(this.lblcod);
            this.Name = "frmcomb";
            this.Text = "Combustísvel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblli;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtli;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncalc;
    }
}