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
        public EventHandler<EventArgs> MarkAllClick { get; set; }
        int diamond2click = 0;
        int diamond1click = 0;
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
        public EventHandler<EventArgs> DiamondClick { get; set; }
        public EventHandler<EventArgs> MarkAllClick1 { get; set; }
        public StudentUserControl()
        {
            MarkAllClick1 = new EventHandler<EventArgs>(MarkAllGreens);
            InitializeComponent();
            AddInspectionComboBox();
            StudentDateLbl.Text = DateTime.Now.ToShortDateString().ToString();
            AddClassworkComboBox();
        }

        private void MarkAllGreens(object sender, EventArgs e)
        {
            greenbtn.Checked = true;
        }

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public void AddClassworkComboBox()
        {
            ClassworkComboBox.DataSource = numbers;
            ClassworkComboBox.SelectedIndex = -1;
        }
        public void AddInspectionComboBox()
        {
            InspectionComboBox.DataSource = numbers1;
            InspectionComboBox.SelectedIndex = -1;
            InspectionComboBox.SelectedItem = "-";
        }
        private void ClassworkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassworkComboBox.BackColor = Color.DarkOrchid;
        }
        private void Diamond1Btn_Click(object sender, EventArgs e)
        {
            if (diamond2click == 0)
            {
                DiamondClick.Invoke(sender, e);
            }
            diamond1click += 1;
        }

        private void Diamond2Btn_Click(object sender, EventArgs e)
        {
            if (diamond2click == 0 && diamond1click == 1)
            {
                DiamondClick.Invoke(sender, e);
                diamond2click += 1;
            }
            else if (diamond2click == 0 && diamond1click == 0)
            {
                DiamondClick.Invoke(sender, e);
                DiamondClick.Invoke(sender, e);
                diamond2click += 1;
            }
        }
        private void Diamond3Btn_Click(object sender, EventArgs e)
        {
            if (diamond2click == 1)
            {
                DiamondClick.Invoke(sender, e);
            }
            else if (diamond2click == 2)
            {
                DiamondClick.Invoke(sender, e);
                DiamondClick.Invoke(sender, e);
                DiamondClick.Invoke(sender, e);
            }
        }
        private void Yellowbtn_CheckedChanged(object sender, EventArgs e)
        {
            ClassworkComboBox.Enabled = true;
            InspectionComboBox.Enabled = true;
            Diamond1Btn.Enabled = true;
            Diamond2Btn.Enabled = true;
            Diamond3Btn.Enabled = true;
            DeleteDiamondBtn.Enabled = true;
            MessageBtn.Enabled = true;
        }
        private void greenbtn_CheckedChanged(object sender, EventArgs e)
        {
            ClassworkComboBox.Enabled = true;
            InspectionComboBox.Enabled = true;
            Diamond1Btn.Enabled = true;
            Diamond2Btn.Enabled = true;
            Diamond3Btn.Enabled = true;
            DeleteDiamondBtn.Enabled = true;
            MessageBtn.Enabled = true;
        }
        private void redbtn_CheckedChanged(object sender, EventArgs e)
        {
            ClassworkComboBox.Enabled = false;
            InspectionComboBox.Enabled = false;
            Diamond1Btn.Enabled = false;
            Diamond2Btn.Enabled = false;
            Diamond3Btn.Enabled = false;
            DeleteDiamondBtn.Enabled = false;
            MessageBtn.Enabled = false;
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Enabled = true; 
        }
        private void AddCommentBtn_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Enabled = false;
            guna2TextBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            AddCommentBtn.FillColor = Color.DodgerBlue;
            RejectCommentBtn.FillColor = Color.DodgerBlue;
        }
    }
}
