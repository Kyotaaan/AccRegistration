using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        public class StudentInfoClass
        {
            public delegate long DelegateNumber(long number);
            public delegate string DelegateText(string txt);

            public static string FirstName = " ";
            public static string LastName = " ";
            public static string MiddleName = " ";
            public static string Address = " ";
            public static string Program = " ";

            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;

            public static string getFirstName(string FirstName)
            {
                return FirstName;
            }
            public static string getLastName(string LastName)
            {
                return LastName;
            }
            public static string getMiddleName(string MiddleName)
            {
                return MiddleName;
            }
            public static string getAddress(string Address)
            {
                return Address;
            }
            public static string getProgram(string Program)
            {
                return Program;
            }
            public static long getAge(long Age)
            {
                return Age;
            }
            public static long getContactNo(long ContactNo)
            {
                return ContactNo;
            }
            public static long getStudentNo(long StudentNo)
            {
                return StudentNo;
            }
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

            FrmConfirm F2 = new FrmConfirm();
            F2.ShowDialog();
        }
    }
}