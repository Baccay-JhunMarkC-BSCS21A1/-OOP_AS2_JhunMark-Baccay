namespace BasicLoginForm
{
    using System;
    using System.IO;
    using System.Text.Json;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        interface IUser
        {
            string Uname { get; }
            string Pword { get; }

            bool ValidateCredentials(string username, string password);
        }

        class User : IUser
        {
            public string Uname { get; set; }
            public string Pword { get; set; }

            public bool ValidateCredentials(string username, string password)
            {
                return Uname == username && Pword == password;
            }

            public static User LoadFromJson(string filePath)
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<User>(json);
            }
        }

        private User userFromJson;

        public Form1()
        {
            InitializeComponent();
            try
            {
                userFromJson = User.LoadFromJson("Person.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading JSON: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UnameV.Text = "";
            PwordV.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Userbox.TextLength == 0 && Passbox.TextLength > 0)
            {
                UnameV.Text = "Please enter username.";
                PwordV.Text = "";
            }
            else if (Userbox.TextLength > 0 && Passbox.TextLength == 0)
            {
                UnameV.Text = "";
                PwordV.Text = "Please enter password.";
            }
            else if (Userbox.TextLength == 0 && Passbox.TextLength == 0)
            {
                UnameV.Text = "Please enter username.";
                PwordV.Text = "Please enter password.";
            }
            else
            {
                if (Userbox.Text != userFromJson.Uname)
                {
                    UnameV.Text = "Username not in records";
                    PwordV.Text = "";
                }
                else if (Passbox.Text != userFromJson.Pword)
                {
                    UnameV.Text = "";
                    PwordV.Text = "Password Incorrect";
                }
                else
                {
                    UnameV.Text = "";
                    PwordV.Text = "";
                    MessageBox.Show("Login successful.");
                }
            }

        }

        private void Userbox_TextChanged(object sender, EventArgs e)
        {
            UnameV.Text = "";
        }

        private void Passbox_TextChanged(object sender, EventArgs e)
        {
            PwordV.Text = "";
        }
    }
}
