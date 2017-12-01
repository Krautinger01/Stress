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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string user;
        private string art;

        StressEntities entity = new StressEntities();
        Stress_Manager sm = new Stress_Manager();

        private void LoadData()
        {
            var managerQuery = from Stress_Manager in entity.Stress_Manager where Stress_Manager.user == user select Stress_Manager;

            List<Stress_Manager> managerList = managerQuery.ToList();

            dataGridView1.DataSource = managerList;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txt_app.Visible = true;
            txt_pass.Visible = true;
            txt_user.Visible = true;
            button4.Visible = true;

            art = "add";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (art == "add")
            {
                sm.user = user;
                sm.application = txt_app.Text;
                sm.username_mail = txt_user.Text;
                sm.password = txt_pass.Text;

                entity.Stress_Manager.Add(sm);

                try
                {
                    entity.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                LoadData();
            }
        }
    }
}
