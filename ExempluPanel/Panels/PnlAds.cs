using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluPanel
{
    internal class PnlAds:Panel
    {
        Label lblTile;
        public PnlAds(FrmHome form)
        {
            this.lblTile = new Label();

            this.Controls.Add(lblTile);
            this.lblTile.Text = "Ads";
            this.lblTile.Location = new Point(66, 9);
            this.lblTile.Size = new Size(34, 20);


            this.Location=new Point(617, 228);
            this.Width=180;
            this.Height=125;
            this.Name="pnlAds";
            this.BackColor=Color.Gray;

        }

    }
}
