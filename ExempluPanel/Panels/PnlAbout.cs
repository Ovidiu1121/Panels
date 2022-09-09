using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluPanel
{
    public class PnlAbout:Panel
    {
        Label lblTitle;

        public PnlAbout(FrmHome form)
        {
            lblTitle = new Label();

            this.Controls.Add(lblTitle);
            this.lblTitle.Text = "About";
            this.lblTitle.Size= new Size(50, 20);
            this.lblTitle.Location=new Point(65, 10);


            this.Location = new Point(428, 97);
            this.Width=180;
            this.Height=125;
            this.Name="pnlAbout";
            this.BackColor=Color.Gray;

        }


    }
}
