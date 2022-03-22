using Copiutza.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copiutza
{
    public partial class loginForm : Form
    {
        List<User> userList = new List<User>();

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            LoadUsers(ref userList);
            userDdataGridView.DataSource = userList;
        }

        private void LoadUsers(ref List<User> userList)
        {

            var t = File.ReadAllText(@"c:\temp\useri.json");
            userList = JsonConvert.DeserializeObject<List<User>>(t);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MockData();
            SaveAllUsers(userList);

        }

        private void MockData()
        {
            Student s = new Student
            {
                Email = "toni@gmail.com",
                Name = "Toni",
                NickName = "Alienkiss",
                Password = "123"
            };

            Admin a = new Admin
            {
                Email = "admin@gmail.com",
                Name = "Administrator Gh.",
                NickName = "Dmini",
                Password = "1234"
            };

            userList.Add(s);
            userList.Add(a);
        }

        private void SaveAllUsers(List<User> userList)
        {
            var t = JsonConvert.SerializeObject(userList);
            File.WriteAllText(@"c:\temp\useri.json", t);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadUsers(ref userList);

            userDdataGridView.DataSource = null;
            userDdataGridView.DataSource = userList;
        }
    }
}