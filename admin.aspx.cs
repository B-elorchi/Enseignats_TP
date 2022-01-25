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
    public partial class admin : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void connecter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67IE6D4\MYDB;
Initial Catalog=school;Integrated Security=SSPI;");
            string rq = "select * from  administrateurs where login =@login and pwd=@pwd";
            //on utilise l'objet command pour executer une requete en utilisant un connexion
            SqlCommand cmd = new SqlCommand(rq, con);
            cmd.Parameters.AddWithValue("@login",login.Text);
            cmd.Parameters.AddWithValue("@pwd", pwd.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Redirect("ListeDesCondidats.aspx");
            }
            else { err.Text = "ce compte n'existe pas , veuiller créer un compte   "; }
            con.Close();
        }
    }
}