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

    public partial class LoginForm : Form
    {
        public Dictionary<string, User> loginFormDictUsers;

        private NewUserForm newUserForm;

        private void addDictUsers(User u)
        {
            loginFormDictUsers.Add(u.username, u);
        }

        public LoginForm()
        {
            InitializeComponent();
            passwordTB.PasswordChar = '*';
            string[] rawLinesLoginFile = File.ReadAllLines("./Login.txt");
            loginFormDictUsers = new Dictionary<string, User>();           
            foreach(var line in rawLinesLoginFile)
            {
                loginFormDictUsers.Add(line.Split(',')[0], new User(line.Split(',')[0], line.Split(',')[1], line.Split(',')[2], line.Split(',')[3], line.Split(',')[4], line.Split(',')[5]));               
            }       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newUserForm = new NewUserForm() { NewUserFormDictUsers = loginFormDictUsers  };
            newUserForm.ShowDialog();           


        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            if (loginFormDictUsers.ContainsKey(usernameTB.Text))
            {
                if (loginFormDictUsers[usernameTB.Text].password == passwordTB.Text)
                {
                    TextEditorForm textEditorForm = new TextEditorForm();
                    textEditorForm.username = loginFormDictUsers[usernameTB.Text].username;
                    textEditorForm.userType = loginFormDictUsers[usernameTB.Text].userType;
                    textEditorForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect");
                }
            }
            else
            {
                MessageBox.Show("User does not exist, please create a new user");
            }
            




        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
