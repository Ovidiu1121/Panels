using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluPanel
{
    internal class PnlMain2:Panel
    {
        Label lblTitle;
        public PnlMain2(FrmHome form)
        {
            lblTitle = new Label();

            this.Controls.Add(lblTitle);
            this.lblTitle.Text = "Main 2";
            this.lblTitle.Location=new Point(182, 10);
            this.lblTitle.Size=new Size(56, 28);

            this.Name="pnlMain2";
            this.Location=new Point(2, 97);
            this.Width=420;
            this.Height=450;
            this.BackColor=Color.Red;

        }


    }
}
