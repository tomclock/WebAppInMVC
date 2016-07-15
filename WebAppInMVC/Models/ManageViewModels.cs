using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Web.Mvc;

namespace WebAppInMVC.Models
{
        /// <summary>
        /// test
        /// </summary>
        public class ProductListViewModel
        {
             public List<SelectListItem> Products { get; set; }
        //    public ProductListViewModel()
        //    {
        //        var productList = new List<SelectListItem>();

        //        var ListProducts = new List<Product>
        //        { new Product {Name = "Tom", Price = 100, ProductId = "1" },
        //          new Product { Name = "Jack", Price = 101, ProductId = "2" },
        //          new Product { Name = "Tim", Price = 101, ProductId = "3" },
        //          new Product { Name = "Hack", Price = 101, ProductId = "4" }};

        //        foreach (Models.Product p in ListProducts)
        //        {
        //            productList.Add(new SelectListItem
        //            {
        //                Value = p.ProductId.ToString(),
        //                Text = "Product: " + p.Name + " " + p.Price.ToString(),
        //                // To set the selected item use the following code 
        //                // Note: you should not set every item to selected
        //                Selected = true
        //            });
        //        }

        //        Products = productList;
        //    }
        //}
         }

        public class IndexViewModel
        {
            public bool HasPassword { get; set; }
            public IList<UserLoginInfo> Logins { get; set; }
            public string PhoneNumber { get; set; }
            public bool TwoFactor { get; set; }
            public bool BrowserRemembered { get; set; }
        }

        public class ManageLoginsViewModel
        {
            public IList<UserLoginInfo> CurrentLogins { get; set; }
            public IList<AuthenticationDescription> OtherLogins { get; set; }
        }

        public class FactorViewModel
        {
            public string Purpose { get; set; }
        }

        public class SetPasswordViewModel
        {
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "New password")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm new password")]
            [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public class ChangePasswordViewModel
        {
            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Current password")]
            public string OldPassword { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "New password")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm new password")]
            [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public class AddPhoneNumberViewModel
        {
            [Required]
            [Phone]
            [Display(Name = "Phone Number")]
            public string Number { get; set; }
        }

        public class VerifyPhoneNumberViewModel
        {
            [Required]
            [Display(Name = "Code")]
            public string Code { get; set; }

            [Required]
            [Phone]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }
        }

        public class ConfigureTwoFactorViewModel
        {
            public string SelectedProvider { get; set; }
            //public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        }
    }
