using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciProgramı
{
    public partial class FrmSiparisOlustur : Form
    {
        public FrmSiparisOlustur()
        {
            InitializeComponent();
        }

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu(){ MenuAdi="Triple Whopper",MenuFiyat=12},
            new Menu(){MenuAdi="Big King",MenuFiyat=9},
            new Menu(){MenuAdi="King Chicken",MenuFiyat=5}
        };
        public static List<EkstraMalzeme> EkstraMalzemeler = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme(){EkstaMalzemeAdi="Ranch Sos",Fiyati=0.5m},
            new EkstraMalzeme(){EkstaMalzemeAdi="Acı Sos",Fiyati=0.5m},
            new EkstraMalzeme(){EkstaMalzemeAdi="Buffalo Sos",Fiyati=0.5m}
        };

       

        private void FrmHamburgerEkle_Load(object sender, EventArgs e)
        {
            foreach (var menu in Menuler)
            {
                cbMenu.Items.Add(menu);
            }
            //flowBoyut.Controls.Add(new RadioButton() { Text = Enum.GetValues(typeof(Boyut).ToString()), Tag = Boyut.Kucuk });
            //flowBoyut.Controls.Add(new RadioButton() { Text = Boyut.Orta.ToString(), Tag = Boyut.Kucuk });
            //flowBoyut.Controls.Add(new RadioButton() { Text = Boyut.Buyuk.ToString(), Tag = Boyut.Kucuk });
            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {
                flowEkstra.Controls.Add(new CheckBox() { Text = ekstra.EkstaMalzemeAdi, Tag = ekstra });
            }

            foreach (Boyut item in Enum.GetValues(typeof(Boyut)))
            {
                flowBoyut.Controls.Add(new RadioButton() { Text = item.ToString(), Tag = item });
            }

            TutarHesapla();
        }

        private void TutarHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
