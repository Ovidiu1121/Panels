using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluPanel
{
    public class PnlNews:Panel
    {
        Label lblTitle;
        public PnlNews(FrmHome form)
        {
            
            lblTitle = new Label();

            this.Controls.Add(lblTitle);
            this.lblTitle.Location = new Point(66, 10);
            this.lblTitle.Size = new Size(45, 20);
            this.lblTitle.Text="News";

            this.Location = new Point(617, 97);
            this.Width=180;
            this.Height=125;
            this.Name="pnlNews";
            this.BackColor=Color.Gray;

        }


    }
}
