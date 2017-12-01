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
                if(sl.username == txt_username.Text && sl.password == PasswordHash.Hash(txt_pass.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
