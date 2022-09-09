using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluPanel
{

    internal class PnlNews2:Panel
    {
        Label lblTitle;
        public PnlNews2(FrmHome form)
        {
            lblTitle = new Label();

            this.Controls.Add(lblTitle);
            this.lblTitle.Location = new Point(66, 10);
            this.lblTitle.Size = new Size(70, 20);
            this.lblTitle.Text="News 2";

            this.Location = new Point(617, 97);
            this.Width=180;
            this.Height=125;
            this.Name="pnlNews2";
            this.BackColor=Color.Yellow;

        }

    }
}
