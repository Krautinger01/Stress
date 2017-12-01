using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StressEntities entity = new StressEntities();

        private bool CheckUser()
        {
            foreach(Stress_Login sl in entity.Stress_Login)
            {
                if(sl.username == txt_username.Text && sl.password == txt_pass.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CheckUser())
            {
                Form2 f2 = new Form2();
                f2.user = txt_username.Text;
                Hide();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Fuck off!", "Du Sau!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Hide();
            f3.ShowDialog();
        }
    }
}
