using Modern_Sliding_Sidebar___C_Sharp_Winform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCV
{
    public partial class Form1 : Form
    {
        bool sideBar_Expand = true;
        public Form1()
        {

            InitializeComponent();
            GeneralForm defaultGF = new GeneralForm();
            addUserControl(defaultGF);

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
      

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
            if (sideBar_Expand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBar_Expand = false;
                    Timer_Sidebar_Menu.Stop();
                }
            }
            else
                {
                    SideBar.Width += 10;
                    if (SideBar.Width == SideBar.MaximumSize.Width)
                    {
                        sideBar_Expand = true;
                        Timer_Sidebar_Menu.Stop();
                    }
                }
        }   
        
        

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }

  

        private void Education_Button_Click(object sender, EventArgs e)
        {
            EducationForm ed= new EducationForm();
            addUserControl(ed);
        }
        
        private void Home_Button_Click(object sender, EventArgs e)
        {
            GeneralForm gf = new GeneralForm();
            addUserControl(gf);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
 

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Activities_Button_Click(object sender, EventArgs e)
        {
            ActivitiesForm ac = new ActivitiesForm();
            addUserControl(ac);
        }

        private void Certificate_Button_Click(object sender, EventArgs e)
        {
            Cert cr = new Cert();
            addUserControl(cr);
        }

        private void Achivements_Button_Click(object sender, EventArgs e)
        {
            AchivementsForm ach = new AchivementsForm();
            addUserControl(ach);
        }

        private void Skills_Button_Click(object sender, EventArgs e)
        {
            SkillForm skill = new SkillForm();
            addUserControl(skill);
        }

      
    }
}
