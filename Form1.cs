using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private readonly Dictionary<string, string> userDatabase = new Dictionary<string, string>
        {
            { "admin", "password123" },
            { "user", "user123" }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string result = ValidateLogin(username, password);
            MessageBox.Show(result, "Login Status");
        }

        public string ValidateLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
                return "Error: Both fields are empty.";
            if (string.IsNullOrWhiteSpace(username))
                return "Error: Username is empty.";
            if (string.IsNullOrWhiteSpace(password))
                return "Error: Password is empty.";
            if (!userDatabase.ContainsKey(username) || userDatabase[username] != password)
                return "Error: Invalid username or password.";
            return "Login successful!";
        }
    }
}
 
