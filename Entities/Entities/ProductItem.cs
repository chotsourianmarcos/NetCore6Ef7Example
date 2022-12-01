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
        public ProductItem()
        {
            this.ProductPassword = Guid.NewGuid().ToString();
        }
        public ProductItem(int ownerID)
        {
            this.ProductPassword = Guid.NewGuid().ToString();
        }

        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
        private string ProductPassword { get; set; }
        public decimal RawPrice { get; set; }

        public void UserDiactivation(string inputPassword)
        {
            if (inputPassword == this.ProductPassword)
            {
                this.IsActive = false;
            }
            else
            {
                throw new ValidationException();
            }
        }
        public void ChangeProductPassword(string productCurrentPassword, string productNewPassword)
        {
            if (productCurrentPassword == this.ProductPassword)
            {
                this.ProductPassword = productNewPassword;
            }
            else
            {
                throw new ValidationException();
            }
        }
    }
}
