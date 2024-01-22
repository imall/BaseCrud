using System.ComponentModel.DataAnnotations;

namespace BaseCrud.Models
{
    public class Employee
    {

        [Display(Name = "員工編號")]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "最少需3個字元!")]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        [Display(Name = "行動電話")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "請輸入Email")]
        [Display(Name = "電子郵件")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "請輸入Department")]
        [Display(Name = "部門")]
        public string Department { get; set; }
        [Display(Name = "職稱")]
        [Required(ErrorMessage = "請輸入Title")]
        public string Title { get; set; }
    }
}
