using ILveILCEJSON_BLL;
using ILveILCEJSON_ENTITYMODELS.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jsonilveilceornek
{
    public partial class FormILSorgulama : Form
    {
        public FormILSorgulama()
        {
            InitializeComponent();
        }


        //Global alan
        ILServis ilServisim = new ILServis();
        ILILceServis ILILceServisim = new ILILceServis();
        private void FormILSorgulama_Load(object sender, EventArgs e)
        {
            //form yüklenirken burası çalışacak
            //combobox içine illeri getirdik
            comboBoxILSEC.DataSource = ilServisim.IlleriGetir();
            comboBoxILSEC.DisplayMember = "ILAdi";
            comboBoxILSEC.ValueMember = "PlakaKodu";
            //ListWiew içini dolduracağız
           
           List<ILILceBilgileri> SehireAitBilgilerListesi= ILILceServisim.BilgileriGetir();
            foreach (var item in SehireAitBilgilerListesi)
            {
                ListViewItem deger = new ListViewItem()
                {
                    Text = item.Ismi,
                    Tag = item
                };
                deger.SubItems.Add(item.Tel);
                deger.SubItems.Add(item.Faks);
                deger.SubItems.Add(item.Mail);
                deger.SubItems.Add(item.Web);
                //ListWİew e ekleme  yapılacak
                listView1.Items.Add(deger);
            }
            //groupbox başlangıcta gizli olmalı.
            groupBoxIL.Enabled = false;
            groupBoxIL.Visible = false;
            //detay göster şeklinde sağ tık menusu gerekiyor
            //bu control toolbox ta var istersek disigner ekranında çekip form üstüne
            //yerleştirebiliriz contextmenu biz kod ekranından yapacağız
            //ContextMenu sonra devam edilecek
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            //comboboxta hangi il seçildiyse onun bilgileri listwiew de görelim
            IL secilenIL=(IL)comboBoxILSEC.SelectedItem;
            //IL secilenIL = comboBoxILSEC.SelectedItem as IL; 2.YOL

            //linq ile sart yazıyoruz. where,firstordefault
            ILILceBilgileri SecilenILbilgiSİ = ILILceServisim.BilgileriGetir().Where(x => x.Plaka == secilenIL.PlakaKodu).FirstOrDefault();
            listView1.Items.Clear();
            ListViewItem deger = new ListViewItem();
            deger.Text = SecilenILbilgiSİ.Ismi;
            deger.Tag = SecilenILbilgiSİ;
            deger.SubItems.Add(SecilenILbilgiSİ.Tel);
            deger.SubItems.Add(SecilenILbilgiSİ.Faks);
            deger.SubItems.Add(SecilenILbilgiSİ.Mail);
            deger.SubItems.Add(SecilenILbilgiSİ.Web);
            listView1.Items.Add(deger);


        }

        private void detayGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxIL.Visible = true;
            groupBoxIL.Enabled = true;
            ILILceBilgileri secilenIL = (ILILceBilgileri)listView1.FocusedItem.Tag;
            richTextBoxIL.Text = secilenIL.Bilgi;
        }
    }
}
