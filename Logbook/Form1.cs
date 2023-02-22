using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook
{
    public partial class Form1 : Form
    {
        StudentUserControl uc;
        public int diamond = 5;
        public List<Student> Students { get; set; }
        public EventHandler<EventArgs> DiamondClick { get; set; }
        public Form1()
        {
            DiamondClick = new EventHandler<EventArgs>(DecreaseDiamond);
            InitializeComponent();
            DateLbl.Text = DateTime.Now.ToLongDateString().ToString();
            Students = new List<Student>
            {
                new Student
                {
                    Name="John",
                    Surname="Johnlu",
                    FatherName="Bob"
                },
                new Student
                {
                    Name="Corc",
                    Surname="Corclu",
                    FatherName="Mike"
                },
                new Student
                {
                    Name="Phillip",
                    Surname="Phillipli",
                    FatherName="Johnny"
                },
                new Student
                {
                    Name="Bob",
                    Surname="Marley",
                    FatherName="Father"
                },
                new Student
                {
                    Name="Oliver",
                    Surname="James",
                    FatherName="Rocky"
                },
                new Student
                {
                    Name="Mike",
                    Surname="Mikeli",
                    FatherName="Oliver"
                }
            };
            int y = 259;
            foreach (var student in Students)
            {
                uc = new StudentUserControl();
                uc.DiamondClick = DiamondClick;
                uc.Name = student.Name;
                uc.Surname = student.Surname;
                uc.Fathername = student.FatherName;
                uc.Location = new Point(15, y);
                y += 60;
                this.Controls.Add(uc);
            }
        }
        public void Markall_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is StudentUserControl uc)
                {
                    uc.GreenBtn.Checked = true;
                }
            }
        }
        private void DecreaseDiamond(object sender, EventArgs e)
        {
            if (diamond > 0 && diamond<=5)
            {
                --diamond;
                DiamondCounttxtb.Text = diamond.ToString();
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LessonTextBox.Enabled = true;
        }
        private void AcceptLessonBtn_Click(object sender, EventArgs e)
        {
            if (LessonTextBox.Text != null)
            {
                LessonTextBox.Enabled = false;
                LessonTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void RejectLessonBtn_Click(object sender, EventArgs e)
        {
            LessonTextBox.Text = String.Empty;
            LessonTextBox.Enabled = false;
        }

        private void MainteacherRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            guna2Button1.Enabled = true;
            AcceptLessonBtn.Enabled = true;
            RejectLessonBtn.Enabled = true;
            guna2Button2.Enabled = true;
            guna2Button1.Enabled = true;
            guna2CustomGradientPanel1.Enabled = true;
            foreach (var item in this.Controls)
            {
                if (item is StudentUserControl uc)
                {
                    uc.Enabled= true;
                }
            }
        }
        private void ReplacedteacherRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            guna2Button1.Enabled = true;
            AcceptLessonBtn.Enabled = true;
            RejectLessonBtn.Enabled = true;
            guna2Button2.Enabled = true;
            guna2Button1.Enabled = true;
            guna2CustomGradientPanel1.Enabled = true;
            foreach (var item in this.Controls)
            {
                if (item is StudentUserControl uc)
                {
                    uc.Enabled = true;
                }
            }
        }
    }
}
