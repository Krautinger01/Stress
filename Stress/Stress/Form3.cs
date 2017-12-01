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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        StressEntities entity = new StressEntities();
        Stress_Login sl = new Stress_Login();

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_pass1.Text == txt_pass2.Text)
            {
                sl.username = txt_username.Text;
                sl.password = txt_pass1.Text;
            
                entity.Stress_Login.Add(sl);

                try
                {
                    entity.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Fuck off!", "Du Sau!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
