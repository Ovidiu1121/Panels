using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluPanel
{
    internal class PnlLinks:Panel
    {
        Label lblTitle;
        public PnlLinks(FrmHome form)
        {
            lblTitle = new Label();

            this.Controls.Add(lblTitle);
            this.lblTitle.Text="Links";
            this.lblTitle.Location=new Point(65, 9);
            this.lblTitle.Size=new Size(41, 20);

            this.Location=new Point(428,228);
            this.Width=180;
            this.Height=125;
            this.Name="pnlLinks";
            this.BackColor=Color.Gray;
        }

    }
}
