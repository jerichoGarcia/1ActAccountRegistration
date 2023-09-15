using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
   
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        
         public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {

            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblLname.Text = DelLastName(StudentInfoClass.LastName);
            lblFname.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMidName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblStudNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            
        }
      
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
