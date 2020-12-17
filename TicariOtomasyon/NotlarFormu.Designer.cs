namespace TicariOtomasyon
{
    partial class NotlarFormu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotlarFormu));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btntemizleme = new DevExpress.XtraEditors.SimpleButton();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelleme = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtkime = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchdetay = new System.Windows.Forms.RichTextBox();
            this.txtbaslik = new DevExpress.XtraEditors.TextEdit();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txthitap = new DevExpress.XtraEditors.TextEdit();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.lblolusturan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtkime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthitap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(-831, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(830, 537);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(34, 101);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 18);
            this.labelControl11.TabIndex = 12;
            this.labelControl11.Text = "Kime : ";
            // 
            // btntemizleme
            // 
            this.btntemizleme.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizleme.Appearance.Options.UseFont = true;
            this.btntemizleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizleme.ImageOptions.Image")));
            this.btntemizleme.Location = new System.Drawing.Point(139, 301);
            this.btntemizleme.Name = "btntemizleme";
            this.btntemizleme.Size = new System.Drawing.Size(112, 32);
            this.btntemizleme.TabIndex = 7;
            this.btntemizleme.Text = "Temizle";
            this.btntemizleme.Click += new System.EventHandler(this.btntemizleme_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(139, 301);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(112, 32);
            this.btntemizle.TabIndex = 9;
            this.btntemizle.Text = "Temizle";
            // 
            // btnguncelleme
            // 
            this.btnguncelleme.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelleme.Appearance.Options.UseFont = true;
            this.btnguncelleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelleme.ImageOptions.Image")));
            this.btnguncelleme.Location = new System.Drawing.Point(21, 301);
            this.btnguncelleme.Name = "btnguncelleme";
            this.btnguncelleme.Size = new System.Drawing.Size(112, 32);
            this.btnguncelleme.TabIndex = 6;
            this.btnguncelleme.Text = "Güncelle";
            this.btnguncelleme.Click += new System.EventHandler(this.btnguncelleme_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(21, 301);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(112, 32);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "Güncelle";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblolusturan);
            this.groupControl1.Controls.Add(this.lblsaat);
            this.groupControl1.Controls.Add(this.lbltarih);
            this.groupControl1.Controls.Add(this.txtkime);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.btntemizleme);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.btnguncelleme);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.rchdetay);
            this.groupControl1.Controls.Add(this.txtbaslik);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1072, -4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(270, 536);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtkime
            // 
            this.txtkime.Location = new System.Drawing.Point(100, 101);
            this.txtkime.Name = "txtkime";
            this.txtkime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkime.Properties.Appearance.Options.UseFont = true;
            this.txtkime.Size = new System.Drawing.Size(116, 24);
            this.txtkime.TabIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(33, 67);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 18);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Başlık  : ";
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(134, 263);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(112, 32);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(16, 263);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(112, 32);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // rchdetay
            // 
            this.rchdetay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchdetay.Location = new System.Drawing.Point(14, 149);
            this.rchdetay.Name = "rchdetay";
            this.rchdetay.Size = new System.Drawing.Size(237, 102);
            this.rchdetay.TabIndex = 3;
            this.rchdetay.Text = "";
            // 
            // txtbaslik
            // 
            this.txtbaslik.Location = new System.Drawing.Point(106, 64);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbaslik.Properties.Appearance.Options.UseFont = true;
            this.txtbaslik.Size = new System.Drawing.Size(116, 24);
            this.txtbaslik.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(99, 23);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(116, 24);
            this.txtid.TabIndex = 0;
            this.txtid.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Detay : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1069, 545);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(549, 351);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // txthitap
            // 
            this.txthitap.Location = new System.Drawing.Point(567, 296);
            this.txthitap.Name = "txthitap";
            this.txthitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthitap.Properties.Appearance.Options.UseFont = true;
            this.txthitap.Size = new System.Drawing.Size(116, 24);
            this.txthitap.TabIndex = 10;
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(34, 355);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(31, 13);
            this.lbltarih.TabIndex = 13;
            this.lbltarih.Text = "Tarih";
            this.lbltarih.Visible = false;
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Location = new System.Drawing.Point(93, 355);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(28, 13);
            this.lblsaat.TabIndex = 13;
            this.lblsaat.Text = "saat";
            this.lblsaat.Visible = false;
            // 
            // lblolusturan
            // 
            this.lblolusturan.AutoSize = true;
            this.lblolusturan.Location = new System.Drawing.Point(30, 387);
            this.lblolusturan.Name = "lblolusturan";
            this.lblolusturan.Size = new System.Drawing.Size(52, 13);
            this.lblolusturan.TabIndex = 14;
            this.lblolusturan.Text = "oluşturan";
            this.lblolusturan.Visible = false;
            // 
            // NotlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2650, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txthitap);
            this.Name = "NotlarFormu";
            this.Text = "NotlarFormu";
            this.Load += new System.EventHandler(this.NotlarFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtkime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthitap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btntemizleme;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnguncelleme;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtkime;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.RichTextBox rchdetay;
        private DevExpress.XtraEditors.TextEdit txtbaslik;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.TextEdit txthitap;
        private System.Windows.Forms.Label lblolusturan;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Label lbltarih;
    }
}