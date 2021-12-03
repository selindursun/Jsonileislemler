using ILveILCEJSON_ENTITYMODELS.Classlar;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ILveILCEJSON_BLL
{
    public class ILILceServis
    {
        private string JsonString = string.Empty;
        ILServis ilServisi = new ILServis();
        public ILILceServis()
        {
            VeriKaynaginaBaglan();
        }
        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient())
            {
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_SELİN\Source\Repos\Jsonileislemler\belediyelerfull.json");
                JsonString = Encoding.UTF8.GetString(data);
            }
        }
        public List<ILILceBilgileri> BilgileriGetir()
        {
            List<ILILceBilgileri> liste = new List<ILILceBilgileri>();
            JObject j = JObject.Parse(JsonString);
            List<String> illerim = ilServisi.IlleriGetir().Select(x => x.ILAdi).ToList();
            illerim = illerim.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();
            foreach (string item in illerim)
            {
                //her bir il için bilgileri belediyelerfull.json'dan çekeceğiz.

                var data = j.SelectToken(item).SelectToken("il");
                ILILceBilgileri detaylıBilgi = new ILILceBilgileri();
                detaylıBilgi.Plaka = Convert.ToByte(data["plaka"].ToObject<string>());
                detaylıBilgi.Tel = data["belediye-tel"] == null ? "" : data["belediye-tel"].ToObject<string>();
                detaylıBilgi.Faks = data["belediye-faks"].ToObject<string>();
                detaylıBilgi.Ismi = data["belediye-ismi"].ToObject<string>();
                detaylıBilgi.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();
                detaylıBilgi.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                detaylıBilgi.Nufus = data["nufus"].ToObject<string>();
                detaylıBilgi.Alankodu = data["alankodu"] == null ? "" : data["alankodu"].ToObject<string>();
                detaylıBilgi.Bolge = data["bolge"].ToObject<string>();
                detaylıBilgi.Bilgi = data["bilgi"].ToString();

                liste.Add(detaylıBilgi);
            }


            return liste;
        }

        public List<ILILceBilgileri> ILAdinaGoreILceleriGetir(string ilAdi)
        {

            List<ILILceBilgileri> liste = new List<ILILceBilgileri>();

            JObject j = JObject.Parse(JsonString);

            List<string> ilclerListem =
                ilServisi.IlleriGetir().Single(x => x.ILAdi == ilAdi).Ilceleri;

            //ağrı ---> agri // ismi json içindeki gibi değiştirdik
            ilAdi = DilIslemleri.TurkceKarakterleriIngilizceyeCevir(ilAdi
                );

            //ilçeler de json içinde ingilizce karakterli halde yazıyor.
            // bu nedenle onu da çevirdik
            ilclerListem = ilclerListem.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();

            foreach (var item in ilclerListem)
            {
                var data = j.SelectToken(ilAdi.ToLower()).SelectToken(item);

                // bazı illerin ilçelerinde null gelme durumuna yakalanmayalım.
                if (data != null)
                {
                    ILILceBilgileri bilgim = new ILILceBilgileri();
                    bilgim.Ismi = data["belediye-ismi"] == null ? "" : data["belediye-ismi"].ToObject<string>();
                    bilgim.Mail = data["belediye-tel"] == null ? "" : data["belediye-tel"].ToObject<string>();
                    bilgim.Mail = data["belediye-faks"] == null ? "" : data["belediye-faks"].ToObject<string>();
                    bilgim.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();
                    bilgim.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                    bilgim.Nufus = data["belediye-nufus"] == null ? "" : data["belediye-nufus"].ToObject<string>();
                    bilgim.Bilgi = data["belediye-bilgi"] == null ? "" : data["belediye-bilgi"].ToObject<string>();
                    liste.Add(bilgim);
                }

            }



            return liste;
        }
    }
}
