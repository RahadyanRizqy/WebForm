using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using Npgsql;

namespace WebForm
{
    public partial class _Default : Page
    {
        protected void btnInsertion_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO students(stud_id, stud_name, stud_uname, stud_pword, stud_email, stud_address) VALUES (@id, @name, @uname, @pword, @email, @address)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@id", Convert.ToInt32(txtStudID.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@name", txtStudName.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@uname", txtStudUname.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@pword", txtStudPword.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@email", txtStudEmail.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@address", txtStudAddr.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    txtStudID.Text = "";
                    txtStudName.Text = "";
                    txtStudUname.Text = "";
                    txtStudPword.Text = "";
                    txtStudEmail.Text = "";
                    txtStudAddr.Text = "";
                    lblmsg.Text = "Student data has been registered";
                }

            }
            catch (Exception ex) { }
        }
        protected void btnSelection_Click(object sender, EventArgs e)
        {
            try /* Select After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM students";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    connection.Close();

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex) { }
        }
        protected void btnUpdation_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE students SET stud_id=@id, stud_name=@name, stud_uname=@uname, stud_pword=@pword, stud_email=@email, stud_address=@address WHERE stud_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@id", Convert.ToInt32(txtStudID.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@name", txtStudName.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@uname", txtStudUname.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@pword", txtStudPword.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@email", txtStudEmail.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@address", txtStudAddr.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    txtStudID.Text = "";
                    txtStudName.Text = "";
                    txtStudUname.Text = "";
                    txtStudPword.Text = "";
                    txtStudEmail.Text = "";
                    txtStudAddr.Text = "";
                    lblmsg.Text = "Student data has been modified";

                }
            }
            catch (Exception ex) { }
        }
        protected void btnDeletion_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM students WHERE stud_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@id", Convert.ToInt32(txtStudentID.Text)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    txtStudentID.Text = "";
                    lblmessage.Text = "Student data has been deleted";

                }
            }
            catch (Exception ex) { }
        }
    }
}