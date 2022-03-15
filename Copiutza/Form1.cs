using Copiutza.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copiutza
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            User u = new User();
            u.NickName = "Toni";
            Console.WriteLine(u.NickName);

            string t = u.NickName;

        }
    }
}
