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
    public partial class InfoList : Form
    {
        public InfoList()
        {
            InitializeComponent();
            
            Facult(comboBox2);
        }
        string nameSp;
        string name;

        private void InfoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyData.con.Close();
            Form check = Application.OpenForms[0];
            check.Close();
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

        private void abitInfo()
        {
            //Заполняем GridView студентами
            SqlCommand abit = MyData.con.CreateCommand();
            abit.CommandText = "gridViewTable";
            abit.CommandType = CommandType.StoredProcedure;
            abit.Parameters.AddWithValue("@nSpec", name);

            SqlDataAdapter adapter = new SqlDataAdapter(abit);


            dataGridView1.DataSource = null;
            DataTable FullDataTable = new DataTable();
            dataGridView1.DataSource = FullDataTable;
            adapter.Fill(FullDataTable);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выводим в комбобокс название специальности
            nameSp = comboBox2.SelectedItem.ToString();
            
            SqlCommand snCom = MyData.con.CreateCommand();
            snCom.CommandText = "spN";
            snCom.CommandType = CommandType.StoredProcedure;
            snCom.Parameters.AddWithValue("@facName", nameSp);
            SqlDataAdapter sAdapter = new SqlDataAdapter(snCom);
            DataTable snTable = new DataTable();
            sAdapter.Fill(snTable);
            comboBox3.Items.Clear();
            
            foreach (DataRow row in snTable.Rows)
            {
                comboBox3.Items.Add((string)row.ItemArray[0]);
                comboBox3.SelectedIndex = 0;
               
            }

            
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void InfoList_Load(object sender, EventArgs e)
        {

        }

        private void InfoList_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           //выводим кол-во бюджетных мест
            name = comboBox3.SelectedItem.ToString();
            Console.WriteLine(name);
            SqlCommand snCom = MyData.con.CreateCommand();
            snCom.CommandText = "usNum";
            snCom.CommandType = CommandType.StoredProcedure;
            snCom.Parameters.AddWithValue("@spName", name);
            SqlDataReader rdr = snCom.ExecuteReader();
            label2.Text = null;
            while(rdr.Read())
            {
                label2.Text = rdr.GetValue(0).ToString();
            }
            rdr.Close();
            abitInfo();


        }
    }
}

