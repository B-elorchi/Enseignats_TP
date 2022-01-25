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
    public partial class ListeDesCondidats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67IE6D4\MYDB;Initial Catalog=school;
Integrated Security=SSPI;");
            string rq = "select * from Condidat";
            SqlCommand cmd = new SqlCommand(rq, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            dr.Close();
            cmd.CommandText = "select count(*) from Condidat";
            int nbc = (int)cmd.ExecuteScalar();
            lbl_nbc.Text = nbc.ToString();
            con.Close();

        }
    }
}