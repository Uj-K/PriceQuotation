using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    
    public class PriceQuotation
    {
        /// <summary>
        /// The sale price  
        /// </summary>
        [Required(ErrorMessage = "Subtotal price is required.")]
        [Range(0.00, double.MaxValue, ErrorMessage = "Subtotal price must to be grater than 0")]
        public decimal Subtotal { get; set; }

        /// <summary>
        /// The present of discount rate
        /// </summary>
        [Required]
        [ Range(0, 100, ErrorMessage = "Discount Percent must to be a valid number from 0 to 100.")]
        public int DiscountPercent { get; set; }


        public decimal DiscountAmount => Subtotal * (DiscountAmount / 100);

        public decimal Total => Subtotal - DiscountAmount;

    }
}

/*• Use the MVC pattern. 
 * To do that, create a model class that stores 
 * the subtotal and discount percent 
 * and calculates the discount amount and total. 
 * Make sure to bind that model to the Razor view 
 * that displays the Price Quotation page shown above.*/
