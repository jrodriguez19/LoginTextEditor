using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginTextEditor
{
    public partial class NewUserForm : Form
    {
        public Dictionary<string, User> NewUserFormDictUsers;

        public NewUserForm()
        {
            InitializeComponent();
            dateTP.Format = DateTimePickerFormat.Custom;
            dateTP.CustomFormat = "dd-MM-yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            if(usernameTB.Text == "" || passwordTB.Text == "" || reEnterPasswordTB.Text == "" || firstNameTB.Text == "" || lastNameTB.Text == "" || userTypeCB.Text == "")
            {
                MessageBox.Show("Please fill out all fields and try again");
            }
            else
            {
                if(passwordTB.Text == reEnterPasswordTB.Text)
                {
                    NewUserFormDictUsers.Add(usernameTB.Text, new User(usernameTB.Text, passwordTB.Text, userTypeCB.Text, firstNameTB.Text, lastNameTB.Text, dateTP.Text));
                    File.AppendAllText("./Login.txt", Environment.NewLine + usernameTB.Text + "," + passwordTB.Text + "," + userTypeCB.Text + "," + firstNameTB.Text + "," + lastNameTB.Text + "," + dateTP.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password and Re-enter Password fields must be equal");
                }
                
            }
                      
        }

        private void exitBT_Click(object sender, EventArgs e)
        {            
            this.Close();           
        }

        private void dateTP_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
