using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursBD
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxFac.Text == "" || comboBoxSpec.Text == "" || textBoxAt.Text == "" || textBoxfName.Text == "" || textBoxlName.Text == "" || textBoxPatron.Text == "" )
            {
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                result = MessageBox.Show("Не все поля заполнены", "Неверные данные", buttons);
            }
            else
            {

            }
        }
    }
}
