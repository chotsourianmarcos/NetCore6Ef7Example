using Security.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        private IPasswordService _passwordService;
        public ProductItem() {
            IsActive = true;
            IsPublic = true;
        }
        public ProductItem(IPasswordService passwordService)
        {
            _passwordService = passwordService;
            IsActive= true;
            IsPublic= true; 
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public UserItem OwnerUser { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; private set; }
        public bool IsPublic { get; private set; }
        public decimal RawPrice { get; set; }

        public void ProductDiactivation(string password)
        {
            if (_passwordService.IsCorrectPassword(OwnerUser.UserName, password))
            {
                this.IsActive = false;
            }
            else
            {
                throw new ValidationException();
            }
        }
    }
}
