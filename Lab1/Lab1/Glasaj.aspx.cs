using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string [] list1 = { "Интернет технологии", "Дигитална електроника", "ООП" };
                lbPredmeti.DataSource = list1;
                lbPredmeti.DataBind();
                string[] list2 = { "6", "5", "6" };
                lbKrediti.DataSource = list2;
                lbKrediti.DataBind();
            }
        }

        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] profesori = {"Гоце Арменски","Магдалена Костоска","Иван Чорбев" };
            if (lbPredmeti.SelectedIndex < 3 && lbPredmeti.SelectedIndex != -1)
                lblprofesor.Text = profesori[lbPredmeti.SelectedIndex];
            else
                lblprofesor.Text = "Не може да се одреди професорот за избраниот предмет";
            lbKrediti.SelectedIndex = lbPredmeti.SelectedIndex;
        }

        protected void btnglasaj_Click(object sender, EventArgs e)
        {
            if (lbPredmeti.SelectedIndex != -1)
                Response.Redirect("Uspeshnoglasanje.aspx");
            else
                lblprofesor.Text = "Изберете предмет!";
        }

        protected void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (lbPredmeti.SelectedIndex != -1)
            {
                lbKrediti.Items.RemoveAt(lbPredmeti.SelectedIndex);
                lbPredmeti.Items.RemoveAt(lbPredmeti.SelectedIndex);
            }
        }

        protected void btndodadi_Click(object sender, EventArgs e)
        {
            ListItem li = new ListItem(tbPredmet.Text);
            lbPredmeti.Items.Add(li);
            ListItem kredit = new ListItem(tbKrediti.Text);
            lbKrediti.Items.Add(kredit);
        }
    }
}