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
    public struct AddStudInfo
    {
        public string lastName;
        public string firstName;
        public string patronName;
        public string passport;
        public string att;
        public string spec1;
        public string spec2;
        public string spec3;

    }
    public partial class AddStudent : Form
    {

        public  AddStudent()
        {
            InitializeComponent();
            Facult(comboBoxFac);
            Facult2(comboBoxFac2);
            Facult3(comboBoxFac3);
            this.CenterToParent();
        }
        string nameSp1;
        string name1;
        string nameSp2;
        string name2;
        string nameSp3;
        string name3;
        public AddStudInfo AddToBd()
        {
            AddStudInfo res;
            res.lastName = textBoxlName.Text;
            res.firstName = textBoxfName.Text;
            res.patronName = textBoxPatron.Text;
            res.passport = textBoxPas.Text;
            res.att = textBoxAt.Text;
            res.spec1 = comboBoxSpec.SelectedItem.ToString();
            res.spec2 = comboBoxSpec2.SelectedItem.ToString();
            res.spec3 = comboBoxSpec3.SelectedItem.ToString();
            return res;
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxFac.Text == "" || comboBoxSpec.Text == "" || textBoxAt.Text == "" || textBoxfName.Text == "" || textBoxlName.Text == "" || textBoxPatron.Text == "" )
            {     
                MessageBox.Show(@"Не все поля заполнены");
                return;
            }
            this.DialogResult = DialogResult.OK;
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
                comboBoxFac.Items.Add((string)row.ItemArray[0]);
                comboBoxFac.SelectedIndex = 0;
            }

        }
        private void Facult2(ComboBox sender)
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
                comboBoxFac2.Items.Add((string)row.ItemArray[0]);
                comboBoxFac2.SelectedIndex = 0;
            }

        }
        private void Facult3(ComboBox sender)
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
                comboBoxFac3.Items.Add((string)row.ItemArray[0]);
                comboBoxFac3.SelectedIndex = 0;
            }

        }

        private void comboBoxFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выводим в комбобокс название специальности
            nameSp1 = comboBoxFac.SelectedItem.ToString();
            SqlCommand snCom = MyData.con.CreateCommand();
            snCom.CommandText = "spN";
            snCom.CommandType = CommandType.StoredProcedure;
            snCom.Parameters.AddWithValue("@facName", nameSp1);
            SqlDataAdapter sAdapter = new SqlDataAdapter(snCom);
            DataTable snTable = new DataTable();
            sAdapter.Fill(snTable);
            comboBoxSpec.Items.Clear();

            foreach (DataRow row in snTable.Rows)
            {
                comboBoxSpec.Items.Add((string)row.ItemArray[0]);
                comboBoxSpec.SelectedIndex = 0;

            }
        }

        private void comboBoxFac2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выводим в комбобокс название специальности
            nameSp2 = comboBoxFac2.SelectedItem.ToString();
            SqlCommand snCom = MyData.con.CreateCommand();
            snCom.CommandText = "spN";
            snCom.CommandType = CommandType.StoredProcedure;
            snCom.Parameters.AddWithValue("@facName", nameSp2);
            SqlDataAdapter sAdapter = new SqlDataAdapter(snCom);
            DataTable snTable = new DataTable();
            sAdapter.Fill(snTable);
            comboBoxSpec2.Items.Clear();

            foreach (DataRow row in snTable.Rows)
            {
                comboBoxSpec2.Items.Add((string)row.ItemArray[0]);
                comboBoxSpec2.SelectedIndex = 0;

            }
        }

        private void comboBoxFac3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выводим в комбобокс название специальности
            nameSp3 = comboBoxFac3.SelectedItem.ToString();
            SqlCommand snCom = MyData.con.CreateCommand();
            snCom.CommandText = "spN";
            snCom.CommandType = CommandType.StoredProcedure;
            snCom.Parameters.AddWithValue("@facName", nameSp3);
            SqlDataAdapter sAdapter = new SqlDataAdapter(snCom);
            DataTable snTable = new DataTable();
            sAdapter.Fill(snTable);
            comboBoxSpec3.Items.Clear();

            foreach (DataRow row in snTable.Rows)
            {
                comboBoxSpec3.Items.Add((string)row.ItemArray[0]);
                comboBoxSpec3.SelectedIndex = 0;

            }
        }
    }

}
