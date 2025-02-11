namespace PriceQuotation.Models
{
    
    public class PriceQuotation
    {
        public int Subtotal { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal Total { get; set; }

    }
}

/*• Use the MVC pattern. 
 * To do that, create a model class that stores 
 * the subtotal and discount percent 
 * and calculates the discount amount and total. 
 * Make sure to bind that model to the Razor view 
 * that displays the Price Quotation page shown above.*/
