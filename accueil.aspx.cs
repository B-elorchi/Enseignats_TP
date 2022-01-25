using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace pratiqueV2Exam2007
{
    public partial class accueil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_début_app.Text += (string)Application["da"];
            lbl_début_session.Text += (string)Session["ds"];
            lbl_users.Text += ((int)Application["users"]).ToString();
            lbl_nom.Text = (string)Session["nom"];
            lbl_prenom.Text = (string)Session["prenom"];
            lbl_genre.Text = (string)Session["genre"];
            lbl_niveau.Text = (string)Session["niveau"];
            lbl_filiere.Text = (string)Session["filiere"];

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67IE6D4\MYDB;Initial Catalog=school;
Integrated Security=SSPI;");
            string rq = "select Notes.num_mod as [N° Module] , Module.nom_mod as [Module],Notes.note as [Note]"+
            "from notes inner join Module on Notes.num_mod = Module.num_mod where code = @code";
            SqlCommand cmd = new SqlCommand(rq, con);
            cmd.Parameters.AddWithValue("@code", (string)Session["code"]);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            dr.Close();
            string rq1 = "select sum(Notes.note) ,avg(Notes.note) from notes inner join Module on Notes.num_mod = Module.num_mod " +
                "where code = @code group by code";
            SqlCommand cmd1 = new SqlCommand(rq1, con);
            cmd1.Parameters.AddWithValue("@code", (string)Session["code"]);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            dr1.Read();
            lbl_total.Text +=((double)dr1[0]).ToString();
            lbl_moyenne.Text += ((double)dr1[1]).ToString();
            dr1.Close();
            con.Close();
        }
    }
}