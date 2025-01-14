using System;
using registro_usuario.Interfaces;
using registro_usuario.Models;

namespace registro_usuario.Services
{
	public class UserService : IUserService
	{
		public UserService(){}

		public Task<User> registerUser(User user)
		{
			return null;
		}
	}
}

