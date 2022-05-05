using System.ComponentModel.DataAnnotations;

namespace PriceQuoteApp.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a subtotal!")]
        [Range(1, 10000, ErrorMessage = "Please enter a number between 1 - 10,000!")]
        public double? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percentage!")]
        [Range(1, 100, ErrorMessage = "Please enter a number between 1 - 100!")]
        public double? DiscountPercent { get; set; }
        public double DiscountAmount { get; set; } = 0;
        public double Total { get; set; } = 0;

        public double CalTotal(double subtotal, double discountAmount)
        {
            double total = subtotal - discountAmount;
            return total;
        }

        public double CalDiscount(double subtotal, double percent)
        {
            double DiscountAmount = (subtotal * percent) / 100;
            return DiscountAmount;

        }
    }
}