using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempluPanel
{
    public partial class FrmHome : Form
    { 
        public FrmHome()
        {
            InitializeComponent();

            this.Controls.Add(new PnlHeader(this));
            this.Controls.Add(new PnlAbout(this));
            this.Controls.Add(new PnlAds(this));
            this.Controls.Add(new PnlFooter(this));
            this.Controls.Add(new PnlLinks(this));
            this.Controls.Add(new PnlMain(this));
            this.Controls.Add(new PnlMain2(this));
            this.Controls.Add(new PnlNews(this));
            this.Controls.Add(new PnlNews2(this));
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }



        public void eraseControl(String  name)
        {
            Control aux = null;

            foreach(Control c in this.Controls)
            {

                if (c.Name.Equals(name))
                {
                    aux=c;
                }
            }


            if (aux!=null)
            {
               aux.Dispose();
            }

        }
    }
}
