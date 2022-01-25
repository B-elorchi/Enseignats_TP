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
    public partial class inscription : System.Web.UI.Page
    {
        string getCode()
        {
            string code = "";
            var rand = new Random();
            for (int ctr = 1; ctr <= 6; ctr++)
                code += Convert.ToChar(rand.Next(65, 91));
            return code;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        
        protected void btn_inscrire_Click(object sender, EventArgs e)  {
            char genre = rd1.Checked ? 'M' : 'F';
            string code=getCode();
            if (nom.Text != "" && prenom.Text != "" )
            {SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67IE6D4\MYDB;Initial Catalog=school;
Integrated Security=SSPI;");
string rq = "insert into Condidat values(@code,@nom,@prenom,@genre,@niveau,@code_fil)";
                //on utilise l'objet command pour executer une requete en utilisant un connexion
                SqlCommand cmd = new SqlCommand(rq, con);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@niveau", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@code_fil", DropDownList2.SelectedItem.Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                lbl_code.Text = "Your code is : " + code; }
        }
    }
}