using System.ComponentModel.DataAnnotations;

namespace test01MVC.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [Display(Name = "Ngay phat hanh")]
        public DateTime CreatedDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Xin hay nhap bat dau bang chu hoa"),]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
    }
}
