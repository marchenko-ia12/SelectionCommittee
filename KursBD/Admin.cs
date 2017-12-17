using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KursBD
{
    public partial class Admin : Form
    {
        SqlDataAdapter searchOwnerAdapter;
        DataTable searchResults = new DataTable();

        public Admin()
        {
            InitializeComponent();
            Facult(comboBox2);
        }
        string nameSp1;
        string name1;
        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void Facult(ComboBox sender)
        {
            // Выводим в комбобокс название факультета
            SqlCommand fnCom = MyData.con.CreateCommand();
            fnCom.CommandText = "fcNames";
            fnCom.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter fAdapter = new SqlDataAdapter(fnCom);
            DataTable fnTable = new DataTable();
            fAdapter.Fill(fnTable);
            foreach (DataRow row in fnTable.Rows)
            {
                comboBox2.Items.Add((string)row.ItemArray[0]);
                comboBox2.SelectedIndex = 0;
            }

        }

        private void AbitInfo()
        {
            //Заполняем GridView студентами
            SqlCommand abit = MyData.con.CreateCommand();
            abit.CommandText = "gridViewTable";
            abit.CommandType = CommandType.StoredProcedure;
            abit.Parameters.AddWithValue("@nSpec", name1);

            SqlDataAdapter adapter = new SqlDataAdapter(abit);

            dataGridViewAbit.DataSource = null;
            DataTable FDTable = new DataTable();
            dataGridViewAbit.DataSource = FDTable;
            adapter.Fill(FDTable);
            Console.WriteLine(FDTable);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выводим в комбобокс название специальности
            nameSp1 = comboBox2.SelectedItem.ToString();         
            SqlCommand snCom = MyData.con.CreateCommand();
            snCom.CommandText = "spN";
            snCom.CommandType = CommandType.StoredProcedure;
            snCom.Parameters.AddWithValue("@facName", nameSp1);
            SqlDataAdapter sAdapter = new SqlDataAdapter(snCom);
            DataTable snTable = new DataTable();
            sAdapter.Fill(snTable);
            comboBox1.Items.Clear();

            foreach (DataRow row in snTable.Rows)
            {
                comboBox1.Items.Add((string)row.ItemArray[0]);
                comboBox1.SelectedIndex = 0;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //выводим кол-во бюджетных мест
            name1 = comboBox1.SelectedItem.ToString();
            Console.WriteLine(name1);
            SqlCommand snCom = MyData.con.CreateCommand();
            snCom.CommandText = "usNum";
            snCom.CommandType = CommandType.StoredProcedure;
            snCom.Parameters.AddWithValue("@spName", name1);
            SqlDataReader rdr = snCom.ExecuteReader();
            label4.Text = null;
            while (rdr.Read())
            {
                label4.Text = rdr.GetValue(0).ToString();
               
            }
            rdr.Close();
            AbitInfo();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddAbitButton_Click(object sender, EventArgs e)
        {
            AddStudent addStudForm = new AddStudent();
            addStudForm.ShowDialog();
            if (addStudForm.DialogResult == DialogResult.OK)
            {
                AddStudInfo addStudInfo = addStudForm.AddToBd();
                bool exception = false;
                try
                {
                    SqlCommand addStCom = MyData.con.CreateCommand();
                    addStCom.CommandText = @"addOwner";
                    addStCom.CommandType = CommandType.StoredProcedure;
                    addStCom.Parameters.AddWithValue("@FirstName", addStudInfo.firstName);
                    addStCom.Parameters.AddWithValue("@MiddleName", addStudInfo.patronName);
                    addStCom.Parameters.AddWithValue("@LastName", addStudInfo.lastName);
                    addStCom.Parameters.AddWithValue("@passport", addStudInfo.passport);
                    addStCom.Parameters.AddWithValue("@att", addStudInfo.att);
                    addStCom.Parameters.AddWithValue("@spec1", addStudInfo.spec1);
                    addStCom.Parameters.AddWithValue("@spec2", addStudInfo.spec2);
                    addStCom.Parameters.AddWithValue("@spec3", addStudInfo.spec3);
                    addStCom.ExecuteNonQuery();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка");
                    exception = true;
                }
                finally
                {
                    //if (!exception)
                    //{
                    //    MessageBox.Show("Владелец успешно добавлен");
                    //    disableInfoTab();
                    //    if (searchOwnerAdapter != null)
                    //    {
                    //        searchResults.Clear();
                    //        searchOwnerAdapter.Fill(searchResults);
                    //        dataGridViewAbit.ClearSelection();
                    //    }
                    //}
                }
            }

        }
        //private SqlDataAdapter SearchOwnerAdapter()
        //{
        //    return searchOwnerAdapter;
        //}
        //private DataTable GetSearchResults()
        //{
        //    return searchResults;
        //}
    }
}
