using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari.Facade;

namespace TicariOtomasyon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        UrunlerFormu urn = new UrunlerFormu();
        MusterilerFormu mus = new MusterilerFormu();
        FirmalarFormu firm = new FirmalarFormu();
        PersonellerFormu prs = new PersonellerFormu();
        RehberFormu rhb = new RehberFormu();
        GiderlerFormu gider = new GiderlerFormu();
        cmbfirma bank = new cmbfirma();
        FaturaFormu ftr = new FaturaFormu();
        NotlarFormu not = new NotlarFormu();
        StoklarFormu stk = new StoklarFormu();
        KasaFormu kasa = new KasaFormu();
        AnaSayfaFormu ana = new AnaSayfaFormu();
        Islem_Kayit_Formu islem = new Islem_Kayit_Formu();
        ŞifreFormu sifre = new ŞifreFormu();
        private void btnurunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urn.IsDisposed)
                urn = new UrunlerFormu();
            urn.MdiParent = this;
            urn.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            lblad.Text = PersonellerORM.AktifPersonel.AD.ToString();
            lblsoyad.Text = PersonellerORM.AktifPersonel.SOYAD.ToString();
                ana = new AnaSayfaFormu();
            ana.MdiParent = this;
            ana.Show();
            ana.Show();
        }

        private void btnmusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mus.IsDisposed)
                mus = new MusterilerFormu();
            mus.MdiParent = this;
            mus.Show();
        }

        private void btnfirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (firm.IsDisposed)
                firm = new FirmalarFormu();
            firm.MdiParent = this;
            firm.Show();
        }

        private void btnpersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (prs.IsDisposed)
                prs = new PersonellerFormu();
            prs.MdiParent = this;
            prs.Show();
        }

        private void btnrehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rhb.IsDisposed)
                rhb = new RehberFormu();
            rhb.MdiParent = this;
            rhb.Show();
        }

        private void btngiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gider.IsDisposed)
                gider = new GiderlerFormu();
            gider.MdiParent = this;
            gider.Show();
        }

        private void btnbankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bank.IsDisposed)
                bank = new cmbfirma();
            bank.MdiParent = this;
            bank.Show();
        }

        private void btnfaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ftr.IsDisposed)
                ftr = new FaturaFormu();
            ftr.MdiParent = this;
            ftr.Show();
        }

        private void btnnotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (not.IsDisposed)
                not = new NotlarFormu();
            not.MdiParent = this;
            not.Show();
        }


        private void btnstoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stk.IsDisposed)
                stk = new StoklarFormu();
            stk.MdiParent = this;
            stk.Show();
        }

        private void btnkasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasa.IsDisposed)
                kasa = new KasaFormu();
            kasa.MdiParent = this;
            kasa.Show();
        }

        private void btnanasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ana.IsDisposed)
                ana = new AnaSayfaFormu();
            ana.MdiParent = this;
            ana.Show();
        }

        private void btnislemkayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (islem.IsDisposed)
                islem = new Islem_Kayit_Formu();
            islem.MdiParent = this;
            islem.Show();
        }

        private void btnayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (sifre.IsDisposed)
                sifre = new ŞifreFormu();
            sifre.MdiParent = this;
            sifre.Show();
        }
    }
}
