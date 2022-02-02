using MySoccerWebApp.Core.Entities;
using MySoccerWebApp.Infrastructure.UnitOfWork;
using MySoccerWebApp.Interfaces.Domains;
using MySoccerWebApp.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace MySoccerWebApp.Business.Domains
{
    public class UserDomain : BaseBusinessDomain, IUserDomain
    {
        #region Properties
        private readonly IUserRepository _userRepository;
        #endregion

        #region Constructors
        public UserDomain(IUnitOfWork unitOfWork, IUserRepository userRepository)
            : base(unitOfWork)
        {
            _userRepository = userRepository;
        }
        #endregion

        #region Methods
        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        public void CreateUser(User user)
        {
            //make a new bite array
            byte[] salt;
            //generate salt
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            //hash password with salt
            var pbkdf2 = new Rfc2898DeriveBytes(user.Password, salt, 10000);
            //place the string in the byte array
            byte[] hash = pbkdf2.GetBytes(20);
            //make new byte array where to store the hashed password+salt
            byte[] hashBytes = new byte[36];
            //place the hash and salt in their respective places
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            //conver byte array to string
            string password = Convert.ToBase64String(hashBytes);

            user.Password = password;
            user.Salt = Convert.ToBase64String(salt);

            _userRepository.Insert(user);
        }

        public bool ValidateUser(string email, string password)
        {
            var validated = false;

            var user = _userRepository.GetUserByEmail(email);
            if (user != null)
            {
                //get the saved string
                string savedPasswordHash = user.Password;
                //turn it into bytes
                byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                //take the salt out of the string
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                //hash the user inputted password with the salt
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);
                //compare results! byte by byte!
                //starting from 16 in the stored array cause 0-15 are the salt there.
                int valid = 1;
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                        valid = 0;
                }
                //if there are no differences between the strings, grant access
                if (valid == 1)
                {
                    validated = true;
                }
            }

            return validated;
        }

        public void UpdateUserLoginStatus(User user)
        {
            user.LoggedIn = !user.LoggedIn;
            _userRepository.Update(user);
        }
        #endregion
    }
}
