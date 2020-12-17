namespace TicariOtomasyon
{
    partial class MailFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkonu = new DevExpress.XtraEditors.TextEdit();
            this.rchmesaj = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btngnder = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkonu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi : ";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(196, 154);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(139, 20);
            this.txtmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Konu : ";
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(196, 196);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(139, 20);
            this.txtkonu.TabIndex = 1;
            // 
            // rchmesaj
            // 
            this.rchmesaj.Location = new System.Drawing.Point(125, 227);
            this.rchmesaj.Name = "rchmesaj";
            this.rchmesaj.Size = new System.Drawing.Size(382, 222);
            this.rchmesaj.TabIndex = 2;
            this.rchmesaj.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mesaj : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 132);
            this.panel1.TabIndex = 3;
            // 
            // btngnder
            // 
            this.btngnder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngnder.Appearance.Options.UseFont = true;
            this.btngnder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btngnder.Location = new System.Drawing.Point(317, 456);
            this.btngnder.Name = "btngnder";
            this.btngnder.Size = new System.Drawing.Size(125, 45);
            this.btngnder.TabIndex = 4;
            this.btngnder.Text = "Gönder";
            this.btngnder.Click += new System.EventHandler(this.btngnder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "MAİL GÖNDERME PANELİ";
            // 
            // MailFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 513);
            this.Controls.Add(this.btngnder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rchmesaj);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailFormu";
            this.Text = "MailFormu";
            this.Load += new System.EventHandler(this.MailFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkonu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtkonu;
        private System.Windows.Forms.RichTextBox rchmesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btngnder;
    }
}