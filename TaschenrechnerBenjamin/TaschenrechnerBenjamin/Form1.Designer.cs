namespace TaschenrechnerBenjamin
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxZahl1 = new System.Windows.Forms.TextBox();
            this.tbxZahl2 = new System.Windows.Forms.TextBox();
            this.lblZahl1 = new System.Windows.Forms.Label();
            this.lblZahl2 = new System.Windows.Forms.Label();
            this.tbxErgebnis = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnGleich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxZahl1
            // 
            this.tbxZahl1.Location = new System.Drawing.Point(123, 77);
            this.tbxZahl1.Name = "tbxZahl1";
            this.tbxZahl1.Size = new System.Drawing.Size(100, 22);
            this.tbxZahl1.TabIndex = 0;
            // 
            // tbxZahl2
            // 
            this.tbxZahl2.Location = new System.Drawing.Point(318, 76);
            this.tbxZahl2.Name = "tbxZahl2";
            this.tbxZahl2.Size = new System.Drawing.Size(100, 22);
            this.tbxZahl2.TabIndex = 1;
            this.tbxZahl2.TextChanged += new System.EventHandler(this.TbxZahl2_TextChanged);
            // 
            // lblZahl1
            // 
            this.lblZahl1.AutoSize = true;
            this.lblZahl1.Location = new System.Drawing.Point(138, 55);
            this.lblZahl1.Name = "lblZahl1";
            this.lblZahl1.Size = new System.Drawing.Size(44, 17);
            this.lblZahl1.TabIndex = 2;
            this.lblZahl1.Text = "Zahl1";
            // 
            // lblZahl2
            // 
            this.lblZahl2.AutoSize = true;
            this.lblZahl2.Location = new System.Drawing.Point(315, 55);
            this.lblZahl2.Name = "lblZahl2";
            this.lblZahl2.Size = new System.Drawing.Size(44, 17);
            this.lblZahl2.TabIndex = 3;
            this.lblZahl2.Text = "Zahl2";
            // 
            // tbxErgebnis
            // 
            this.tbxErgebnis.Location = new System.Drawing.Point(610, 76);
            this.tbxErgebnis.Name = "tbxErgebnis";
            this.tbxErgebnis.Size = new System.Drawing.Size(100, 22);
            this.tbxErgebnis.TabIndex = 4;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(123, 145);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(59, 23);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(123, 174);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(59, 23);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btnGleich
            // 
            this.btnGleich.Location = new System.Drawing.Point(518, 77);
            this.btnGleich.Name = "btnGleich";
            this.btnGleich.Size = new System.Drawing.Size(55, 23);
            this.btnGleich.TabIndex = 7;
            this.btnGleich.Text = "=";
            this.btnGleich.UseVisualStyleBackColor = true;
            this.btnGleich.Click += new System.EventHandler(this.BtnGleich_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGleich);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tbxErgebnis);
            this.Controls.Add(this.lblZahl2);
            this.Controls.Add(this.lblZahl1);
            this.Controls.Add(this.tbxZahl2);
            this.Controls.Add(this.tbxZahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxZahl1;
        private System.Windows.Forms.TextBox tbxZahl2;
        private System.Windows.Forms.Label lblZahl1;
        private System.Windows.Forms.Label lblZahl2;
        private System.Windows.Forms.TextBox tbxErgebnis;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnGleich;
    }
}

