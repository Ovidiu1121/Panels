using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluPanel
{
    internal class PnlFooter:Panel
    {
        Label lblTitle;

        public PnlFooter(FrmHome form)
        {
            this.Location = new Point(428, 359);
            this.Width=369;
            this.Height=188;
            this.Name="pnlFooter";
            this.BackColor=Color.MediumPurple;

            lblTitle=new Label();

            this.Controls.Add(lblTitle);
            this.lblTitle.Text="Footer";
            this.lblTitle.Size=new Size(129, 50);
            this.lblTitle.Location=new Point(154, 9);
            

        }


    }
}
