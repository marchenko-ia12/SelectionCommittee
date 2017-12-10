using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KursBD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogPass());
        }
    }
}
static class MyData
{
    public static int idUser;
    public static string surnameUser;
    public static string nameUser;
    public static string patronymicUser;
    public static string nameRole;
    public static SqlConnection con { get; set; }
    public static string connection(string login, string password)
    {
        try
        {
            con = new SqlConnection(@"Data Source=MSSQL-2K8;Initial Catalog=marchenko_kursovaya;User ID=marchenko-414;Password=123456q");
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM CheckPSW(@log, @psw)";
            com.Parameters.AddWithValue("@log", login);
            com.Parameters.AddWithValue("@psw", password);
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                idUser = reader.GetInt32(0);
                surnameUser = reader.GetString(1);
                nameUser = reader.GetString(2);
                if (reader.GetValue(3).ToString() != "") patronymicUser = reader.GetString(3);
                else patronymicUser = "";
                nameRole = reader.GetString(4);
                string logServ = reader.GetString(5);
                string pswServ = reader.GetString(6);
                reader.Close();

                SqlCommand com1 = con.CreateCommand();
                com1.CommandType = CommandType.StoredProcedure;
                com1.CommandText = "sp_setapprole";
                com1.Parameters.AddWithValue("@rolename", logServ);
                com1.Parameters.AddWithValue("@password", pswServ);
                com1.ExecuteNonQuery();
            }
            else
            {
                reader.Close();
                con.Close();
                nameRole = "NONE";

            }
            return nameRole;

        }
        catch (SqlException error)
        {
            MessageBox.Show(error.Message, "Проблемы с подключением");
            return "";
        }

    }
}

