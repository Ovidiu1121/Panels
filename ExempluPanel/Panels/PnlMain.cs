using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluPanel
{
    internal class PnlMain:Panel
    {
        Label lblTitle;
        Button btnNews1;
        Button btnNews2;
        FrmHome form;

        public PnlMain(FrmHome form)
        {
            lblTitle = new Label();
            this.form=form;

            this.Controls.Add(lblTitle);
            this.lblTitle.Text = "Main 1";
            this.lblTitle.Location=new Point(182, 10);
            this.lblTitle.Size=new Size(56,28);


            this.Name="pnlMain1";
            this.Location=new Point(2, 97);
            this.Width=420;
            this.Height=450;
            this.BackColor=Color.Orange;

            btnNews1 = new Button();

            this.Controls.Add(btnNews1);
            this.btnNews1.Location = new Point(144, 96);
            this.btnNews1.Size= new Size(109, 29);
            this.btnNews1.BackColor=Color.White;
            this.btnNews1.Text="Show news 1";
            this.btnNews1.Click+=new EventHandler(this.show_news1_Click);

            btnNews2 = new Button();

            this.Controls.Add(btnNews2);
            this.btnNews2.Location = new Point(144, 140);
            this.btnNews2.Size= new Size(109, 29);
            this.btnNews2.BackColor=Color.White;
            this.btnNews2.Text="Show news 2";
            this.btnNews2.Click+=new EventHandler(this.show_main2_Click);

        }
        private void show_news1_Click(object sender, EventArgs e)
        {
            this.form.eraseControl(("pnlNews2"));
            this.form.Controls.Add(new PnlNews(form));
        }

        private void show_main2_Click(object sender, EventArgs e)
        {

            this.form.eraseControl("pnlNews");
            this.form.Controls.Add(new PnlNews2(form));

        }

    }
}
