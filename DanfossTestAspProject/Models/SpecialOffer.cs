using System.ComponentModel.DataAnnotations;

namespace DanfossTestAspProject.Models
{
    public class SpecialOffer
    {
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Размер скидки.
        /// </summary>
        [RegularExpression(@"^[0-9]{1,2}(\.[0-9]{1,2})?$", ErrorMessage = "Только десятичное значение")]
        public decimal DiscountPercentage { get; set; }

        /// <summary>
        /// Название продукта.
        /// </summary>
        public string ProductName { get; set; }
    }
}
