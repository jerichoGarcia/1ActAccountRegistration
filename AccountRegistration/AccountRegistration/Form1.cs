using System.Collections;
using System.Diagnostics.Eventing.Reader;

namespace AccountRegistration
{

    public partial class FrmRegistration : Form
    {
        
        public FrmRegistration()
        {
            InitializeComponent();
          
        }
        

        public void ShowDialog()
        {
            FrmConfirm confrm = new FrmConfirm();
            if (confrm.ShowDialog() == DialogResult.OK)
            {
                txtStudNo.ResetText();
                txtLname.ResetText();
                txtFname.ResetText();
                txtMidName.ResetText();
                txtAge.ResetText();
                txtContNo.ResetText();
                txtAddress.ResetText();
                cmbProgram.ResetText();
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            ArrayList proglist = new ArrayList();

            proglist.Add("BS in Information Technology");
            proglist.Add("BS in Computer Science");
            proglist.Add("BS in Information System");
            proglist.Add("BS in Computer Engineering");

            foreach(string prog in proglist)
            {
                cmbProgram.Items.Add(prog);
            }
        }
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            StudentInfoClass.Program = cmbProgram.Text.ToString();
            StudentInfoClass.FirstName = txtFname.Text.ToString();
            StudentInfoClass.LastName = txtLname.Text.ToString();
            StudentInfoClass.MiddleName = txtMidName.Text.ToString();
            StudentInfoClass.Address = txtAddress.Text.ToString();
            StudentInfoClass.Age = long.Parse(txtAge.Text);
            StudentInfoClass.ContactNo = long.Parse(txtContNo.Text);
            StudentInfoClass.StudentNo = long.Parse(txtStudNo.Text);

            ShowDialog();
        }

        private void txtStudNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtContNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

}