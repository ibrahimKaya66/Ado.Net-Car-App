using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public static class Data
    {
        private static SqlConnection conn;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataSet ds;
        private static SqlDataReader dr;
        public static string user, pass;
        public static void Connection()
        {
            conn = new SqlConnection("Data Source=109-01;Initial Catalog=Car;Integrated Security=True");
        }
        public static void Open()
        {
            conn.Open();
        }

        public static void Close()
        {
            conn.Close();
        }

        public static void Login()
        {
            Connection();
            Open();
            string cmdText = "select * from Users";
            cmd = new SqlCommand(cmdText, conn);
            dr =  cmd.ExecuteReader();
            while(dr.Read())
            {
                user = dr[0].ToString();
                pass = dr[1].ToString();
            }
            Close();

        }

        public static List<string> ListBrand()
        {
            List<string> list_Brand = new List<string>();
            Connection();
            Open();
            string cmdText = "select Description_ from Brand";
            cmd = new SqlCommand(cmdText, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list_Brand.Add(dr["Description_"].ToString());
            }

            Close();

            return list_Brand;
        }

        public static List<string> ListFuelType()
        {
            List<string> list_Fuel = new List<string>();
            Connection();
            Open();
            string cmdText = "select Description_ from FuelType";
            cmd = new SqlCommand(cmdText, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list_Fuel.Add(dr["Description_"].ToString());
            }

            Close();

            return list_Fuel;
        }

        public static List<string> ListGear()
        {
            List<string> list_Gear = new List<string>();
            Connection();
            Open();
            string cmdText = "select Description_ from Gear";
            cmd = new SqlCommand(cmdText, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list_Gear.Add(dr["Description_"].ToString());
            }

            Close();

            return list_Gear;
        }

        public static List<string> ListBodyType()
        {
            List<string> list_Body = new List<string>();
            Connection();
            Open();
            string cmdText = "select Description_ from BodyType";
            cmd = new SqlCommand(cmdText, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list_Body.Add(dr["Description_"].ToString());
            }

            Close();

            return list_Body;
        }

        private static FrmAdd fa;
        public static void InsertCar()
        {
            fa = (FrmAdd)Application.OpenForms["FrmAdd"];
            Connection();
            Open();
            string cmdText = "insert into Info values(@brand,@model,@price,@year,@fuel,@gear,@km,@body,@power,@color)";
            cmd = new SqlCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("@brand", fa.cbBrand.Text);
            cmd.Parameters.AddWithValue("@model", fa.txtModel.Text);
            cmd.Parameters.AddWithValue("@price", int.Parse(fa.txtPrice.Text));
            cmd.Parameters.AddWithValue("@year", int.Parse(fa.txtYear.Text));
            cmd.Parameters.AddWithValue("@fuel", fa.cbFuelType.Text);
            cmd.Parameters.AddWithValue("@gear", fa.cbGear.Text);
            cmd.Parameters.AddWithValue("@km", int.Parse(fa.txtKm.Text));
            cmd.Parameters.AddWithValue("@body", fa.cbBodyType.Text);
            cmd.Parameters.AddWithValue("@power", Convert.ToInt16(fa.txtPower.Text));
            cmd.Parameters.AddWithValue("@color", fa.txtColor.Text);
            cmd.ExecuteNonQuery();

            Close();
        }
        private static FrmList fl;
        public static void GridFill(string param)
        {
            fl = (FrmList)Application.OpenForms["FrmList"];
            Connection();
            Open();
            string cmdText = "select * from Info "+param;
            da = new SqlDataAdapter(cmdText, conn);
            ds = new DataSet();
            da.Fill(ds);
            fl.dataGridView1.DataSource = ds.Tables[0];
            Close();
            GridEdit();
        }

        private static void GridEdit()
        {
            
        }

        public static void Delete(int id)
        {
            Connection();
            Open();
            string cmdtext = "delete from Info where Id = @id";
            cmd = new SqlCommand(cmdtext, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            Close();
        }
        public static void Update(int id)
        {
            fa = (FrmAdd)Application.OpenForms["FrmAdd"];
            Connection();
            Open();
            string cmdtext = "update Info set Brand = @brand,Model = @model,Price = @price,Year_ = @year,Fuel  = @fuel,Gear = @gear,Km = @km,Body = @body,Power_ = @power,Color = @color where Id = @id";
            cmd = new SqlCommand(cmdtext, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@brand",fa.cbBrand.Text);
            cmd.Parameters.AddWithValue("@model", fa.txtModel.Text);
            cmd.Parameters.AddWithValue("@price", Convert.ToDouble(fa.txtPrice.Text));
            cmd.Parameters.AddWithValue("@year", int.Parse(fa.txtYear.Text));
            cmd.Parameters.AddWithValue("@fuel", fa.cbFuelType.Text);
            cmd.Parameters.AddWithValue("@gear", fa.cbGear.Text);
            cmd.Parameters.AddWithValue("@km", int.Parse(fa.txtKm.Text));
            cmd.Parameters.AddWithValue("@body", fa.cbBodyType.Text);
            cmd.Parameters.AddWithValue("@power", Int16.Parse(fa.txtPower.Text));
            cmd.Parameters.AddWithValue("@color", fa.txtColor.Text);
            cmd.ExecuteNonQuery();
            Close();
        }
    }
}
