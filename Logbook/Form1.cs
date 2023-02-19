using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook
{
    public partial class Form1 : Form
    {
        public List<Student> Students { get; set; }
        public Form1()
        {
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
                }
            };
            int y = 259;
            foreach (var student in Students)
            {
                var uc = new StudentUserControl();
                uc.Name = student.Name;
                uc.Surname = student.Surname;
                uc.Fathername = student.FatherName;
                uc.Location = new Point(15, y);
                y += 60;
                this.Controls.Add(uc);
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
    }
}
