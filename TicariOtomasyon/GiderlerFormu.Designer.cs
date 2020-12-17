namespace TicariOtomasyon
{
    partial class GiderlerFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiderlerFormu));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbyil = new System.Windows.Forms.ComboBox();
            this.cmbay = new System.Windows.Forms.ComboBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btntemizleme = new DevExpress.XtraEditors.SimpleButton();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelleme = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtelektrik = new DevExpress.XtraEditors.TextEdit();
            this.txtekstra = new DevExpress.XtraEditors.TextEdit();
            this.txtinternet = new DevExpress.XtraEditors.TextEdit();
            this.txtdogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnsilme = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchnotlar = new System.Windows.Forms.RichTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtsu = new DevExpress.XtraEditors.TextEdit();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtekstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.SuspendLayout();
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
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1069, 545);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbyil);
            this.groupControl1.Controls.Add(this.cmbay);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btntemizleme);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.btnguncelleme);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Controls.Add(this.txtelektrik);
            this.groupControl1.Controls.Add(this.txtekstra);
            this.groupControl1.Controls.Add(this.txtinternet);
            this.groupControl1.Controls.Add(this.txtdogalgaz);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.btnsilme);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.rchnotlar);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtsu);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1082, -4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(270, 536);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "groupControl1";
            // 
            // cmbyil
            // 
            this.cmbyil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbyil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbyil.FormattingEnabled = true;
            this.cmbyil.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmbyil.Location = new System.Drawing.Point(98, 93);
            this.cmbyil.Name = "cmbyil";
            this.cmbyil.Size = new System.Drawing.Size(121, 27);
            this.cmbyil.TabIndex = 1;
            // 
            // cmbay
            // 
            this.cmbay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbay.FormattingEnabled = true;
            this.cmbay.Items.AddRange(new object[] {
            "OCAK",
            "ŞUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN",
            "TEMMUZ",
            "AĞUSTOS",
            "EYLÜL",
            "EKİM",
            "KASIM",
            "ARALIK"});
            this.cmbay.Location = new System.Drawing.Point(98, 63);
            this.cmbay.Name = "cmbay";
            this.cmbay.Size = new System.Drawing.Size(121, 27);
            this.cmbay.TabIndex = 0;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(17, 261);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(60, 18);
            this.labelControl11.TabIndex = 12;
            this.labelControl11.Text = "Ekstra  : ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(8, 285);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(53, 18);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Notlar : ";
            // 
            // btntemizleme
            // 
            this.btntemizleme.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizleme.Appearance.Options.UseFont = true;
            this.btntemizleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizleme.ImageOptions.Image")));
            this.btntemizleme.Location = new System.Drawing.Point(143, 446);
            this.btntemizleme.Name = "btntemizleme";
            this.btntemizleme.Size = new System.Drawing.Size(112, 32);
            this.btntemizleme.TabIndex = 9;
            this.btntemizleme.Text = "Temizle";
            this.btntemizleme.Click += new System.EventHandler(this.btntemizleme_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(143, 446);
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
            this.btnguncelleme.Location = new System.Drawing.Point(25, 446);
            this.btnguncelleme.Name = "btnguncelleme";
            this.btnguncelleme.Size = new System.Drawing.Size(112, 32);
            this.btnguncelleme.TabIndex = 9;
            this.btnguncelleme.Text = "Güncelle";
            this.btnguncelleme.Click += new System.EventHandler(this.btnguncelleme_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(25, 446);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(112, 32);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "Güncelle";
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
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtelektrik
            // 
            this.txtelektrik.Location = new System.Drawing.Point(98, 127);
            this.txtelektrik.Name = "txtelektrik";
            this.txtelektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtelektrik.Properties.Appearance.Options.UseFont = true;
            this.txtelektrik.Size = new System.Drawing.Size(116, 24);
            this.txtelektrik.TabIndex = 2;
            // 
            // txtekstra
            // 
            this.txtekstra.Location = new System.Drawing.Point(98, 255);
            this.txtekstra.Name = "txtekstra";
            this.txtekstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtekstra.Properties.Appearance.Options.UseFont = true;
            this.txtekstra.Size = new System.Drawing.Size(116, 24);
            this.txtekstra.TabIndex = 6;
            // 
            // txtinternet
            // 
            this.txtinternet.Location = new System.Drawing.Point(98, 225);
            this.txtinternet.Name = "txtinternet";
            this.txtinternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtinternet.Properties.Appearance.Options.UseFont = true;
            this.txtinternet.Size = new System.Drawing.Size(116, 24);
            this.txtinternet.TabIndex = 5;
            // 
            // txtdogalgaz
            // 
            this.txtdogalgaz.Location = new System.Drawing.Point(98, 190);
            this.txtdogalgaz.Name = "txtdogalgaz";
            this.txtdogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdogalgaz.Properties.Appearance.Options.UseFont = true;
            this.txtdogalgaz.Size = new System.Drawing.Size(116, 24);
            this.txtdogalgaz.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(13, 133);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 18);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Elektrik  : ";
            // 
            // btnsilme
            // 
            this.btnsilme.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsilme.Appearance.Options.UseFont = true;
            this.btnsilme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsilme.ImageOptions.Image")));
            this.btnsilme.Location = new System.Drawing.Point(138, 408);
            this.btnsilme.Name = "btnsilme";
            this.btnsilme.Size = new System.Drawing.Size(112, 32);
            this.btnsilme.TabIndex = 8;
            this.btnsilme.Text = "Sil";
            this.btnsilme.Click += new System.EventHandler(this.btnsilme_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(138, 408);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(112, 32);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "Sil";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(20, 408);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(112, 32);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // rchnotlar
            // 
            this.rchnotlar.Location = new System.Drawing.Point(20, 309);
            this.rchnotlar.Name = "rchnotlar";
            this.rchnotlar.Size = new System.Drawing.Size(232, 83);
            this.rchnotlar.TabIndex = 7;
            this.rchnotlar.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(9, 228);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 18);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "İnternet : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(8, 195);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(86, 18);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Doğal Gaz  : ";
            // 
            // txtsu
            // 
            this.txtsu.Location = new System.Drawing.Point(98, 160);
            this.txtsu.Name = "txtsu";
            this.txtsu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsu.Properties.Appearance.Options.UseFont = true;
            this.txtsu.Size = new System.Drawing.Size(116, 24);
            this.txtsu.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(98, 23);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(116, 24);
            this.txtid.TabIndex = 0;
            this.txtid.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(45, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Su : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(48, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Yıl : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ay : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(46, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(559, 351);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 96);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // GiderlerFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2650, 561);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "GiderlerFormu";
            this.Text = "GiderlerFormu";
            this.Load += new System.EventHandler(this.GiderlerFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtekstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btntemizleme;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnguncelleme;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtdogalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnsilme;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.RichTextBox rchnotlar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtsu;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.TextEdit txtekstra;
        private DevExpress.XtraEditors.TextEdit txtinternet;
        private DevExpress.XtraEditors.TextEdit txtelektrik;
        private System.Windows.Forms.ComboBox cmbyil;
        private System.Windows.Forms.ComboBox cmbay;
    }
}