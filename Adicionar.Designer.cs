namespace Mega_Sena
{
    partial class Adicionar
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
            this.btLimpar = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLimpar
            // 
            this.btLimpar.Image = global::Mega_Sena.Properties.Resources.icons8_excluir_30;
            this.btLimpar.Location = new System.Drawing.Point(19, 125);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(87, 50);
            this.btLimpar.TabIndex = 7;
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(19, 75);
            this.txt1.MaxLength = 2;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(37, 21);
            this.txt1.TabIndex = 0;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoNumeros);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(60, 75);
            this.txt2.MaxLength = 2;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(37, 21);
            this.txt2.TabIndex = 1;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoNumeros);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(101, 75);
            this.txt3.MaxLength = 2;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(37, 21);
            this.txt3.TabIndex = 2;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoNumeros);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(142, 75);
            this.txt4.MaxLength = 2;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(37, 21);
            this.txt4.TabIndex = 3;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoNumeros);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(183, 75);
            this.txt5.MaxLength = 2;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(37, 21);
            this.txt5.TabIndex = 4;
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoNumeros);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(224, 75);
            this.txt6.MaxLength = 2;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(37, 21);
            this.txt6.TabIndex = 5;
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoNumeros);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Controls.Add(this.txt6);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt5);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Cadastrar novos números  ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe os números e clique em Salvar\r\nClique na lixeira pra limpar\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::Mega_Sena.Properties.Resources.icons8_salvar_30;
            this.btSalvar.Location = new System.Drawing.Point(174, 125);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(87, 50);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 222);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Mega Sena";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Adicionar_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}