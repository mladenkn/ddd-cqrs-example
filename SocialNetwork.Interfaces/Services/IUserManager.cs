﻿using System.Threading.Tasks;
using SocialNetwork.Models;

namespace SocialNetwork.Interfaces.Services
{
    public interface IUserManager
    {
        Task<User> GetOneByUsernameAsync(string username);
    }
}
