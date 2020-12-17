namespace TicariOtomasyon
{
    partial class GirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsifre = new DevExpress.XtraEditors.TextEdit();
            this.btngiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(541, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(541, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre : ";
            // 
            // txtsifre
            // 
            this.txtsifre.EditValue = "";
            this.txtsifre.Location = new System.Drawing.Point(621, 142);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Properties.UseSystemPasswordChar = true;
            this.txtsifre.Size = new System.Drawing.Size(135, 20);
            this.txtsifre.TabIndex = 1;
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(621, 179);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(105, 39);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(499, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ticari Otomasyon";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(621, 103);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(135, 20);
            this.msktc.TabIndex = 0;
            this.msktc.ValidatingType = typeof(int);
            // 
            // GirisFormu
            // 
            this.AcceptButton = this.btngiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(785, 484);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "GirisFormu";
            this.Text = "AdminFormu";
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtsifre;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktc;
    }
}