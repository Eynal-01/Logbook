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
                    Name="Valentine",
                    Surname="Valentineli",
                    FatherName="UFUFUF"
                }
            };
            int y = 200;
            foreach (var student in Students)
            {
                var uc = new StudentUserControl();
                uc.Location = new Point(0, y);
                y += 70;
                this.Controls.Add(uc);
                uc.Name= student.Name;  
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
