using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.User;
using api.Models;

namespace api.Mappers
{
    public static class UserMappers
    {
        public static UserDto ToUserDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password,
                FullName = user.FullName,
                Role = user.Role,
                CreatedAt = user.CreatedAt,
                IsActive = user.IsActive,
            };
        }
    }
}
