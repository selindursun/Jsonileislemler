﻿using ILveILCEJSON_BLL;
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
        private void FormILSorgulama_Load(object sender, EventArgs e)
        {
            //form yüklenirken burası çalışacak
            //combobox içine illeri getirdik
            comboBoxILSEC.DataSource = ilServisim.IlleriGetir();
            comboBoxILSEC.DisplayMember = "ILAdi";
            comboBoxILSEC.ValueMember = "PlakaKodu";
            //ListWiew içini dolduracağız
            ILILceServis ILILceServisim = new ILILceServis();
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

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            //ILILceServis deneme = new ILILceServis();
           // deneme.BilgileriGetir();

        }
    }
}
