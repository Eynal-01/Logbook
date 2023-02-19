﻿using System;
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
    public partial class StudentUserControl : UserControl
    {
        public string Name
        {
            get { return StudentNameLbl.Text; }
            set { StudentNameLbl.Text = value; }
        }
        public string Surname
        {
            get { return StudentSurnameLbl.Text; }
            set { StudentSurnameLbl.Text = value; }
        }
        public string Fathername
        {
            get { return StudentFatherNameLbl.Text; }
            set { StudentFatherNameLbl.Text = value; }
        }
        public StudentUserControl()
        {
            InitializeComponent();
            StudentDateLbl.Text = DateTime.Now.ToShortDateString().ToString();
        }
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
    }
}
