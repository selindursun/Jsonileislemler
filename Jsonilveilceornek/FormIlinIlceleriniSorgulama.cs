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
    public partial class FormIlinIlceleriniSorgulama : Form
    {
        public FormIlinIlceleriniSorgulama()
        {
            InitializeComponent();
        }

        //Global alan
        ILServis ilServisim = new ILServis();
        ILILceServis ilceServis = new ILILceServis();
        private void FormIlinIlceleriniSorgulama_Load(object sender, EventArgs e)
        {
            comboBoxILLER.DataSource = ilServisim.IlleriGetir();
            comboBoxILLER.DisplayMember = "ILAdi";
            comboBoxILLER.ValueMember = "PlakaKodu";

        }

        private void comboBoxILLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            //içindeki değer değiştiğinde bu metot tetiklenecek
            IL secilenIL = comboBoxILLER.SelectedItem as IL;
            //bll in bilgileri getirmesine ihtiyac var
            //BLL de öyle bir metot olmalı ki il ismini parametre olarak verince detay bilgilerini versin.
            List<ILILceBilgileri> sehreAitIlcelerListem = ilceServis.ILAdinaGoreILceleriGetir(secilenIL.ILAdi);
                listView1.Items.Clear();
            foreach (var item in sehreAitIlcelerListem)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Ismi;
                li.Tag = item;
                li.SubItems.Add(item.Tel);
                li.SubItems.Add(item.Mail);

                //listview içine ekleyeceğim
                listView1.Items.Add(li);
            }
        }
    }
}
