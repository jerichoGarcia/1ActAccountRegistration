using System.Diagnostics.Eventing.Reader;

namespace AccountRegistration
{

    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }


        private void btnNext_Click(object sender, EventArgs e)
        { 
            StudentInfoClass.Program = cmbProgram.Text.ToString();
            StudentInfoClass.FirstName = txtFname.Text.ToString();
            StudentInfoClass.LastName = txtLname.Text.ToString();
            StudentInfoClass.MiddleName = txtMidName.Text.ToString();
            StudentInfoClass.Address = txtAddress.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(txtAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(txtContNo.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(txtStudNo.Text);   
        }
    }

}