namespace kategorijeVozila1
{
    partial class Form1
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtBrojKotaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(31, 30);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(206, 22);
            this.txtModel.TabIndex = 0;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(31, 74);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(206, 22);
            this.txtGodinaProizvodnje.TabIndex = 1;
            // 
            // txtBrojKotaca
            // 
            this.txtBrojKotaca.Location = new System.Drawing.Point(31, 127);
            this.txtBrojKotaca.Name = "txtBrojKotaca";
            this.txtBrojKotaca.Size = new System.Drawing.Size(206, 22);
            this.txtBrojKotaca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Godina proizvodnje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj kotača:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(31, 156);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(97, 34);
            this.btnUnesi.TabIndex = 6;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(134, 155);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(103, 35);
            this.btnObradi.TabIndex = 7;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(31, 196);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(206, 42);
            this.btnIspis.TabIndex = 8;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(284, 30);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(379, 208);
            this.txtIspis.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 281);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojKotaca);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtBrojKotaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

