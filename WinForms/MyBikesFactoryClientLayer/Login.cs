using MyBikesFactoryBusinessLayer;
using MyBikesFactoryDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyBikesFactoryClientLayer
{
    public partial class Login : Form
    {
        private List<SerializableItem> listOfUsers = new List<SerializableItem>();

        public Login()
        {
            InitializeComponent();
        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var result = from user in listOfUsers.Cast<User>()
                       where
                            user.UserName == txtUsername.Text &&
                            user.Password == Security.ComputeHash(txtPassword.Text)
                       select user;
            if (result.Count() == 0)
                MessageBox.Show("User not found!");
            else
            {
                Security.CurrentUser = result.First();
                Form1 frm = new Form1();
                frm.Text = $"Welcome {Security.CurrentUser.UserName}";
                frm.Show();
                this.Hide();
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ////Uncomment the following lines in order to recreate the login.txt file:
            //listOfUsers = new List<SerializableItem>()
            //{
            //    new User() { UserName="user1", Password=Security.ComputeHash("lili2019") },
            //    new User() { UserName="user2", Password=Security.ComputeHash("bell2020") }
            //};
            //using (var fileHandler = new TextFileHandler())
            //{
            //    fileHandler.WriteToFile("login", listOfUsers);
            //}

            try
            {
                using (var fileHandler = new TextFileHandler())
                {
                    listOfUsers = fileHandler.ReadFromFile<SerializableItem>("login");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
