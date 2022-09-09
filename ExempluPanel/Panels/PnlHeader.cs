using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluPanel
{
    public class PnlHeader:Panel
    {
        Label lblTitle;
        Button btnShowMain2;
        Button btnShowMain1;
        FrmHome form;
        public PnlHeader(FrmHome form)
        {
            this.form=form;
            lblTitle = new Label();

            this.Controls.Add(lblTitle);
            this.lblTitle.Location = new Point(369, 7);
            this.lblTitle.Size = new Size(75, 28);
            this.lblTitle.Text="Header";

            this.Width=795;
            this.Height=89;
            this.Location=new Point(2, 2);
            this.Name="pnlHeader";
            this.BackColor=Color.Blue;

            btnShowMain2 = new Button();

            this.Controls.Add(btnShowMain2);
            this.btnShowMain2.Location = new Point(21, 10);
            this.btnShowMain2.Text="Show Main 2";
            this.btnShowMain2.BackColor=Color.White;
            this.btnShowMain2.Size = new Size(114, 29);

            this.btnShowMain2.Click+=new EventHandler(this.ovidiu_show_main2_Click);

            btnShowMain1=new Button();

            this.Controls.Add(btnShowMain1);
            this.btnShowMain1.Location = new Point(21, 45);
            this.btnShowMain1.Text="Show Main 1";
            this.btnShowMain1.BackColor=Color.White;
            this.btnShowMain1.Size = new Size(114, 29);
            this.btnShowMain1.Click+=new EventHandler(this.ovidiu_show_main1_Click);

        }

        private void ovidiu_show_main1_Click(object sender, EventArgs e)
        {

            this.form.Controls.Add(new PnlMain(form));
            this.form.eraseControl("pnlMain2");
          

        }
        private void ovidiu_show_main2_Click(object sender, EventArgs e)
        {
            this.form.Controls.Add(new PnlMain2(form));
            this.form.eraseControl("pnlMain1");
            

        }


    }
}
