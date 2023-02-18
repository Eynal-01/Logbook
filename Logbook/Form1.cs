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
            Students=new List<Student>
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
                    FatherName="vtt"
                }
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
