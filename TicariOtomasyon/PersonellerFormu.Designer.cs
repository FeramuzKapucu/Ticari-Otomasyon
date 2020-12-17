namespace TicariOtomasyon
{
    partial class PersonellerFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonellerFormu));
            this.cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btntemizleme = new DevExpress.XtraEditors.SimpleButton();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelleme = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtgorev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchadres = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.msktlf = new System.Windows.Forms.MaskedTextBox();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.txtsoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lblsifre = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbilce
            // 
            this.cmbilce.Location = new System.Drawing.Point(86, 259);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(116, 20);
            this.cmbilce.TabIndex = 7;
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(86, 229);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbil.Properties.Appearance.Options.UseFont = true;
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(116, 24);
            this.cmbil.TabIndex = 6;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(86, 171);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(116, 26);
            this.msktc.TabIndex = 4;
            this.msktc.ValidatingType = typeof(int);
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
            this.labelControl11.Location = new System.Drawing.Point(8, 288);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(59, 18);
            this.labelControl11.TabIndex = 12;
            this.labelControl11.Text = "Görev  : ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(8, 312);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 18);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Adres : ";
            // 
            // btntemizleme
            // 
            this.btntemizleme.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizleme.Appearance.Options.UseFont = true;
            this.btntemizleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizleme.ImageOptions.Image")));
            this.btntemizleme.Location = new System.Drawing.Point(143, 457);
            this.btntemizleme.Name = "btntemizleme";
            this.btntemizleme.Size = new System.Drawing.Size(112, 32);
            this.btntemizleme.TabIndex = 13;
            this.btntemizleme.Text = "Temizle";
            this.btntemizleme.Click += new System.EventHandler(this.btntemizleme_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(143, 457);
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
            this.btnguncelleme.Location = new System.Drawing.Point(25, 457);
            this.btnguncelleme.Name = "btnguncelleme";
            this.btnguncelleme.Size = new System.Drawing.Size(112, 32);
            this.btnguncelleme.TabIndex = 12;
            this.btnguncelleme.Text = "Güncelle";
            this.btnguncelleme.Click += new System.EventHandler(this.btnguncelleme_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(25, 457);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(112, 32);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "Güncelle";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblsifre);
            this.groupControl1.Controls.Add(this.cmbilce);
            this.groupControl1.Controls.Add(this.cmbil);
            this.groupControl1.Controls.Add(this.msktc);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btntemizleme);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.btnguncelleme);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Controls.Add(this.txtgorev);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.rchadres);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.msktlf);
            this.groupControl1.Controls.Add(this.txtmail);
            this.groupControl1.Controls.Add(this.txtsoyad);
            this.groupControl1.Controls.Add(this.txtad);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1072, -4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(270, 536);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtgorev
            // 
            this.txtgorev.Location = new System.Drawing.Point(86, 285);
            this.txtgorev.Name = "txtgorev";
            this.txtgorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgorev.Properties.Appearance.Options.UseFont = true;
            this.txtgorev.Size = new System.Drawing.Size(116, 24);
            this.txtgorev.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 136);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(69, 18);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Telefon  : ";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(71, 419);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(144, 32);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // rchadres
            // 
            this.rchadres.Location = new System.Drawing.Point(20, 320);
            this.rchadres.Name = "rchadres";
            this.rchadres.Size = new System.Drawing.Size(232, 83);
            this.rchadres.TabIndex = 9;
            this.rchadres.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(42, 252);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 18);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "İlçe : ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(51, 228);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 18);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "İl : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(35, 204);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 18);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Mail  : ";
            // 
            // msktlf
            // 
            this.msktlf.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktlf.Location = new System.Drawing.Point(83, 133);
            this.msktlf.Mask = "(999) 000-0000";
            this.msktlf.Name = "msktlf";
            this.msktlf.Size = new System.Drawing.Size(116, 26);
            this.msktlf.TabIndex = 3;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(85, 203);
            this.txtmail.Name = "txtmail";
            this.txtmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Properties.Appearance.Options.UseFont = true;
            this.txtmail.Size = new System.Drawing.Size(116, 24);
            this.txtmail.TabIndex = 5;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(83, 93);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Properties.Appearance.Options.UseFont = true;
            this.txtsoyad.Size = new System.Drawing.Size(116, 24);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(83, 60);
            this.txtad.Name = "txtad";
            this.txtad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Properties.Appearance.Options.UseFont = true;
            this.txtad.Size = new System.Drawing.Size(116, 24);
            this.txtad.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(83, 20);
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
            this.labelControl5.Location = new System.Drawing.Point(35, 170);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "TC  : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Soyad : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ad : ";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 4);
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
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(549, 351);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(567, 296);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(116, 24);
            this.textEdit1.TabIndex = 10;
            // 
            // lblsifre
            // 
            this.lblsifre.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Appearance.Options.UseFont = true;
            this.lblsifre.Location = new System.Drawing.Point(83, 504);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(27, 18);
            this.lblsifre.TabIndex = 14;
            this.lblsifre.Text = "şifre";
            this.lblsifre.Visible = false;
            // 
            // PersonellerFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2650, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textEdit1);
            this.Name = "PersonellerFormu";
            this.Text = "PersonellerFormu";
            this.Load += new System.EventHandler(this.PersonellerFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private System.Windows.Forms.MaskedTextBox msktc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btntemizleme;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnguncelleme;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtgorev;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.RichTextBox rchadres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox msktlf;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private DevExpress.XtraEditors.TextEdit txtsoyad;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl lblsifre;
    }
}