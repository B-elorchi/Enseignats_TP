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
    public partial class login : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void connecter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67IE6D4\MYDB;Initial Catalog=school;Integrated Security=SSPI;");
            string rq = "select * from  Condidat where nom =@nom and code=@code";
            //on utilise l'objet command pour executer une requete en utilisant un connexion
            SqlCommand cmd = new SqlCommand(rq, con);
            cmd.Parameters.AddWithValue("@nom",nom.Text);
            cmd.Parameters.AddWithValue("@code", code.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Session["code"] = (string)dr[0];
                Session["nom"] = (string)dr[1];
                Session["prenom"] = (string)dr[2];
                Session["genre"] = (string)dr[3];
                Session["niveau"] = (string)dr[4];
                Session["filiere"] = (string)dr[5];
                Response.Redirect("accueil.aspx");
            }
            else { err.Text = "ce compte n'existe pas , veuiller créer un compte   "; }
            con.Close();
        }
    }
}