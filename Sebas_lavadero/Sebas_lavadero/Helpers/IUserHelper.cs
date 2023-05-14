﻿using Microsoft.AspNetCore.Identity;
using Sebas_lavadero.DAL.Entities;
using Sebas_lavadero.Models;

namespace Sebas_lavadero.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        //Task<User> AddUserAsync(AddUserViewModel addUserViewModel);

        Task AddRoleAsync(string roleName); //Yo tengo los Roles: Admin y User, estos dos roles los va a agregar en la tabla AspNetRoles

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel loginViewModel);

        Task LogoutAsync();

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<User> GetUserAsync(Guid userId); //Sobrecargado
    }
}
