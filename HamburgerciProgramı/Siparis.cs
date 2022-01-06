using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProgramı
{
    public class Siparis
    {
        public Menu SecilenMenu { get; set; } //menu
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }//ekstra Malzeme
        public Boyut Boyutu { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SecilenMenu.MenuFiyat;
            ToplamTutar = ToplamTutar * Adet;
            //if (Boyutu == Boyut.Orta)
            //{
            //    ToplamTutar = ToplamTutar + 2;
            //}
            //else if (Boyutu == Boyut.Buyuk)
            //{
            //    ToplamTutar = ToplamTutar + 5;
            //}
            switch (Boyutu)
            {
                case Boyut.Orta: ToplamTutar += ToplamTutar + 2;
                    break;
                case Boyut.Buyuk:ToplamTutar += ToplamTutar + 5;
                    break;
            }

            foreach (var ekstraMalzeme in EkstraMalzemeler)
            {
                ToplamTutar += ekstraMalzeme.Fiyati;
            }            
        }

        //public string EkranaYaz()
        //{
        //    if (EkstraMalzemeler.Count ==0)
        //    {
        //        return SecilenMenu.MenuAdi + "Menü, x" + Adet + "," + Boyutu + " Boy," + "Toplam: " + ToplamTutar;
        //    }
        //    else
        //    {
        //        string exMalzemeler=null;
        //        foreach (var item in EkstraMalzemeler)
        //        {
        //            exMalzemeler += item.EkstaMalzemeAdi +",";
        //        }

        //        return SecilenMenu.MenuAdi + "Menü, x" + Adet + "," + Boyutu + " Boy," + "Malzemeler("+exMalzemeler+")" + "Toplam: " + ToplamTutar;

        //    }
        //}

        public override string ToString()
        {
            if (EkstraMalzemeler.Count ==0)
            {
                return string.Format("{0} Menu,x{1} Adet,{2} Boy,Tutar: {3}", SecilenMenu.MenuAdi, Adet, Boyutu, ToplamTutar);
            }
            else
            {
                string exMalzemeler = null;
                foreach (var item in EkstraMalzemeler)
                {
                    exMalzemeler += item.EkstaMalzemeAdi + ",";
                }
                return string.Format("{0} Menu,x{1} Adet,{2},({3}) Boy,Tutar: {4}", SecilenMenu.MenuAdi, Adet, Boyutu, exMalzemeler, ToplamTutar);
            }
        }
    }
}
