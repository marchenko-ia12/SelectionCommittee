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

            string userLabel = MyData.surnameUser + " " + MyData.nameUser + " " + MyData.patronymicUser;
            label2.Text = userLabel;

            speciality(comboBox1);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;


        }

        private void InfoList_Load(object sender, EventArgs e)
        {

        }

        private void InfoList_FormClosed(object sender, FormClosedEventArgs e)
        {
           MyData.con.Close();
           Form check = Application.OpenForms[0];
           check.Close();
        }

        private void speciality (ComboBox sender)
        {
            
            sender.Items.Add("Приоритет 1");
            sender.Items.Add("Приоритет 2");
            sender.Items.Add("Приоритет 3");
            sender.SelectedIndex = 0;
        }

        private void abitInfo()
        {
            int priorityNumber = 1;

            switch (comboBox1.Text)
            {
                case "Приоритет 1":
                    priorityNumber = 1;
                    break;
                case "Приоритет 2":
                    priorityNumber = 2;
                    break;
                case "Приоритет 3":
                    priorityNumber = 3;
                    break;
            }
            

            
            //Вытаскиваем название специальности
            SqlCommand spName = MyData.con.CreateCommand();
            spName.CommandText = "Select * from specNames(@prNum)";
            spName.Parameters.AddWithValue("@prNum", priorityNumber);
            SqlDataReader reader4 = spName.ExecuteReader();
            reader4.Read();
            string specName = reader4.GetString(0);




            //Заполняем студентами в зависимости от приоритета
            SqlCommand com3 = MyData.con.CreateCommand();
            com3.CommandText = "SELECT  DISTINCT lastName, firstName,patronName " +
                                "from dbo.enrolee,dbo.speciality " +
                                "where (@prNum=1 and specName= @prName and spec1_id=spec_id) " +
                                 "or (@prNum=2 and specName= @prName and spec2_id=spec_id) " +
                                 "or (@prNum=3 and specName= @prName and spec3_id=spec_id) " +
                                "group by  lastName, firstName,patronName";
            com3.Parameters.AddWithValue("@prNum", priorityNumber);
            com3.Parameters.AddWithValue("@prName", specName);
            SqlDataReader reader3 = com3.ExecuteReader();
            reader3.Read();

            DataTable FullDataTable = new DataTable();
            FullDataTable.Load(reader3);


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FullDataTable;
            // dataGridView1.Columns["Предмет"].Frozen = true;
            for (int i = 1; i <= dataGridView1.Columns.Count - 1; i++)
            {
                dataGridView1.Columns[i].Width = 52;
                dataGridView1.Columns[i].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 7);
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            abitInfo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
