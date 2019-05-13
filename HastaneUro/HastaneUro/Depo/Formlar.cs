using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneUro.Depo
{
    class Formlar
    {
     public void Hasta()
        {
            Bilgi.HastaBilgi hs = new Bilgi.HastaBilgi();
            hs.MdiParent = Form.ActiveForm;
            hs.WindowState = FormWindowState.Maximized;
            hs.Show();
        }
        public int DrListe(bool secim = false)
        {
            Bilgi.DoktorListe frm = new Bilgi.DoktorListe();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            
            return AnaSayfa.Aktarma;
        }
        public int OpListe(bool secim = false)
        {
            Bilgi.OperasyonTurleri frm = new Bilgi.OperasyonTurleri();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }

            return AnaSayfa.Aktarma;
        }
        public int HastaList(bool secim = false)
        {
            Bilgi.HastaListesi frm = new Bilgi.HastaListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            return AnaSayfa.Aktarma;
        }
        public void Sorgu()
        {
            Bilgi.Sorgulama hs = new Bilgi.Sorgulama();
            hs.MdiParent = Form.ActiveForm;
            hs.WindowState = FormWindowState.Maximized;
            hs.Show();
        }

    }
}
