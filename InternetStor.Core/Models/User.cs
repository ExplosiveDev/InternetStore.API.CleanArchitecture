using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InternetStore.Core.Models
{
	public class User
	{

		public const int MAX_NAME_LENGHT = 64;
		private User(Guid id, string userName, string email, string hashedPassword)
        {
            Id = id;
            UserName = userName;
            PasswordHash = hashedPassword;
            Email = email;
        }
        public Guid Id { get; set; }
		public string UserName { get; private set; }
		public string PasswordHash { get; private set; }
		public string Email { get; private set; }

        public static (User User, string Error) Create(Guid id, string userName, string email, string hashedPassword)
        {
			var error = string.Empty;

			if (string.IsNullOrEmpty(userName) || userName.Length > MAX_NAME_LENGHT)
				error = "Product name can't be empty or longer then " + MAX_NAME_LENGHT + " characters\n";

            var user = new User(id, userName, email, hashedPassword);

			return (user, error);
        }
    }
}
