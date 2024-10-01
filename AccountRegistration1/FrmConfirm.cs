using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AccountRegistration1.FrmRegistration;
using static AccountRegistration1.FrmRegistration.StudentInfoClass;

namespace AccountRegistration1
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelNumStudentNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.getProgram);
            DelFirstName = new DelegateText(StudentInfoClass.getFirstName);
            DelLastName = new DelegateText(StudentInfoClass.getLastName);
            DelMiddleName = new DelegateText(StudentInfoClass.getMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.getAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.getAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.getContactNo);
            DelNumStudentNo = new DelegateNumber(StudentInfoClass.getStudentNo);

            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblFirst.Text = DelFirstName(StudentInfoClass.FirstName);
            lblLast.Text = DelLastName(StudentInfoClass.LastName);
            lblMiddle.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAddress.Text = DelAddress(StudentInfoClass.Address);

            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContact.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblStudent.Text = DelNumStudentNo(StudentInfoClass.StudentNo).ToString();

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblProgram.Text = StudentInfoClass.Program;
            lblFirst.Text = StudentInfoClass.FirstName;
            lblLast.Text = StudentInfoClass.LastName;
            lblMiddle.Text = StudentInfoClass.MiddleName;
            lblAddress.Text = StudentInfoClass.Address;
            lblAge.Text = StudentInfoClass.Age.ToString();
            lblContact.Text = StudentInfoClass.ContactNo.ToString();
            lblStudent.Text = StudentInfoClass.StudentNo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.FirstName = tbFirst.Text.ToString();
            StudentInfoClass.LastName = tbLast.Text.ToString();
            StudentInfoClass.MiddleName = tbMiddle.Text.ToString();
            StudentInfoClass.Address = tbAddress.Text.ToString();
            StudentInfoClass.Age = long.Parse(tbAge.Text.ToString());
            StudentInfoClass.StudentNo = long.Parse(tbStudent.Text.ToString());
            StudentInfoClass.ContactNo = long.Parse(tbContact.Text.ToString());

            FrmConfirm confirmForm = new FrmConfirm();
            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
                cbProgram.ResetText();
                tbFirst.Clear();
                tbLast.Clear();
                tbMiddle.Clear();
                tbAddress.Clear();
                tbAge.Clear();
                tbStudent.Clear();
                tbContact.Clear();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}