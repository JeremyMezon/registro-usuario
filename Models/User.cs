
using System;
namespace registro_usuario.Models
{
	public class User
	{
		public string name { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public List<Phone> phones { get; set; }
    }
}

