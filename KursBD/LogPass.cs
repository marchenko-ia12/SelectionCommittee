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
    public partial class LogPass : Form
    {
        public LogPass()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string nameRole = MyData.connection(login, password);
            if( nameRole == "2")
            {
                InfoList inf = new InfoList();
                this.Hide();
                inf.Show();
            }
            else if (nameRole == "NONE")
            {
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                result = MessageBox.Show("Missing user. Login or Pass error");
                textBox1.Text = "";
                textBox2.Text = "";

            }
            else if(nameRole == "Комиссия" || nameRole == "Администратор")
            {
                Admin inf = new Admin();
                this.Hide();
                inf.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") { button1.Enabled = true; }
            else { button1.Enabled = false; }
        }
    }
}
