﻿using Microsoft.AspNetCore.Mvc;
using TestArchitecture.BL;
using TestArchitecture.Core;
using TestArchitecture.DA;

namespace TestArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
		private IUsersService _userService;

		public UsersController()
		{
			IUsersRepository usersRepository = new UsersRepository();
			_userService = new UsersService(usersRepository);
		}

		[HttpGet]
		public User[] Get(string userName)
		{
			var user = _userService.Get();

			var result = new User();

			return new[] { result };
		}

		[HttpPost]
		public User Create(User newUser)
		{
			var user = new Core.User
			{
				Age = newUser.Age,
				Name = newUser.Name
			};

			_userService.Create(user);

			return newUser;
		}

		[HttpGet("model")]
		public void GetModel([FromQuery] User user)
		{
			var model = user.GetType();

			foreach (var propetry in model.GetProperties())
			{
				foreach (var customAttribute in propetry.CustomAttributes)
				{
					if (customAttribute.AttributeType.Name == "RequiredAttribute")
					{
						var value = propetry.GetValue(user);
						var specifiedValue = Convert.ChangeType(value, propetry.PropertyType);

						if (value is DateTime dateValue && dateValue == default(DateTime))
						{
							throw new Exception($"{propetry.Name}: {value}");
						}

						if (value is int intValue && intValue == default(int))
						{
							throw new Exception($"{propetry.Name}: {value}");
						}

						if (value == null)
						{
							throw new Exception($"{propetry.Name}: {value}");
						}
					}
				}
			}
		}
	}
}
