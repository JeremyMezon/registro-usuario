using System;
using registro_usuario.Models;

namespace registro_usuario.Interfaces
{
	public interface IUserService
	{
		public Task<User> registerUser(User user);
	}
}

