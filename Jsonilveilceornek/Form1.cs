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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ILToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //açık bir form varsa onu kapat.
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Hide();
            }
            FormILSorgulama formILSorgulama = new FormILSorgulama();
            formILSorgulama.MdiParent = this;
            formILSorgulama.Show();
            //form içinde form boyutlarında göstermesi için ayarlama yap
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void ILCESorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild!=null)
            {
                
                    this.ActiveMdiChild.Hide();

            }

            FormIlinIlceleriniSorgulama formIlce = new FormIlinIlceleriniSorgulama();

            formIlce.MdiParent = this;
            formIlce.Show();

            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
