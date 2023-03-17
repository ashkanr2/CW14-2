using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CW14_1.Models.ViewModels
{
    public class CompleteOrderViewModel
    {
        [Display(Name = "CartNumber")]
        [Required(ErrorMessage = "عدد وارد کنید")]
        [MaxLength(16)]
        [Remote(controller: "Payment", action: "CheckCardNumber", ErrorMessage = "با 6037 شروع شود ")]
        public string? CartNumber { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "عدد وارد کنید")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "کد امنیتی ضروریست")]
        [MaxLength(4)]
        [MinLength(4)]
        [Display(Name = "CapchaCode")]
        public string? CapchaCode { get; set; }

      
        [Required(ErrorMessage = "کد cvv2 ضروریست")]
        [StringLength(4,ErrorMessage ="بیشتر از 4 رقم")]
        [MinLength(3,ErrorMessage ="کمتر از 3 رقم نباشد")]
        [Display(Name = "cvv2")]
        public string cvv2 { get; set; }
        [Display(Name = "cvv2Cheker")]

        [Required(ErrorMessage = "تکرار کد cvv2 ضروریست")]
        [Compare(nameof(cvv2), ErrorMessage ="cvv2 یکسان نیست")]
        public string cvv2Cheker { get; set; }
    }
}
