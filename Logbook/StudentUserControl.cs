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
    public partial class StudentUserControl : UserControl
    {
        public StudentUserControl()
        {
            InitializeComponent();
            StudentDateLbl.Text = DateTime.Now.ToShortDateString().ToString();
        }

       
    }
}
