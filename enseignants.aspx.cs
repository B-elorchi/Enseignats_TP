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
    public partial class enseignants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add(new ListItem(""));
            if (!Page.IsPostBack)
            {
                string texte, value;
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-650AUIVB\SQLEXPRESS;Initial Catalog=school_asp;
                Integrated Security=SSPI;");
                string rq = "select code , nom+'  '+prenom as name from Condidat";
                SqlCommand cmd = new SqlCommand(rq, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    texte = (string)dr[1];
                    value = (string)dr[0];
                    DropDownList1.Items.Add(new ListItem(texte, value));
                }
                dr.Close();
                con.Close();
            }
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_code.Text = DropDownList1.SelectedItem.Value;
            

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-650AUIVB\SQLEXPRESS;Initial Catalog=school_asp;Integrated Security=SSPI;");
            string rq = "select Notes.num_mod as [N° Module] , Module.nom_mod as [Module],Notes.note as [Note]" +
            "from notes inner join Module on Notes.num_mod = Module.num_mod where code = @code";
            SqlCommand cmd = new SqlCommand(rq, con);
            cmd.Parameters.AddWithValue("@code", (string)DropDownList1.SelectedItem.Value);
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
            cmd1.Parameters.AddWithValue("@code", (string)DropDownList1.SelectedItem.Value);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            dr1.Read();
            lbl_total.Text += ((double)dr1[0]).ToString();
            lbl_moyenne.Text += ((double)dr1[1]).ToString();
            dr1.Close();
            con.Close();
        }
    }
}