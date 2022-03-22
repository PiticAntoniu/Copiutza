using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copiutza.Entities
{
    internal class User
    {
        #region data
        string nickName;
        string name;
        string email;
        string password;

        public string NickName { 
            get => nickName; 
            set => nickName = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        #endregion data

        protected internal void ResetPassword()
        {
            // reset password
            if (GetMail() == email)
            {
                MailHelpers.SendMail(email, MiscHelpers.GeneratePassword());
            }
        }

        protected internal string GetMail()
        {
            throw new NotImplementedException();
        }
    }
}
