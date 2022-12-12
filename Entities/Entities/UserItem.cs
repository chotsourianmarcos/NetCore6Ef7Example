using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Security.IServices;

namespace Entities.Entities
{
    public class UserItem
    {
        private IPasswordService _passwordService;
        public UserItem() { }
        public UserItem(IPasswordService passwordService)
        {
            _passwordService = passwordService;
            IsActive = true;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public string UserName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; private set; }
        public int IdRol { get; set; }
        private string Password { get; set; }
        private string EncryptedPassword { get; set; }

        public void UserDiactivation(string userName, string password)
        {
            if (ValidateUserPassword(userName, password))
            {
                this.IsActive = false;
            }
            else
            {
                throw new ValidationException();
            }
        }
        public void ChangeUserPassword(string userName, string oldPassword, string newPassword)
        {
            if (ValidateUserPassword(userName, oldPassword))
            {
                this.Password = newPassword;
            }
            else
            {
                throw new ValidationException();
            }
        }
        private bool ValidateUserPassword(string userName, string password)
        {
            if (_passwordService.IsCorrectPassword(userName, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
