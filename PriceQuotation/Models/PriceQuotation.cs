﻿using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    
    public class PriceQuotation
    {
        /// <summary>
        /// The sale price  
        /// </summary>
        [Required(ErrorMessage = "Subtotal price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Subtotal price must to be grater than 0")]
        public decimal Subtotal { get; set; } = 0;

        /// <summary>
        /// The present of discount rate
        /// </summary>
        [Required(ErrorMessage = "Discount percent is required.")]
        [Range(0, 100, ErrorMessage = "Discount Percent must to be a valid number from 0 to 100.")]
        public int DiscountPercent { get; set; } = 0;


        public decimal DiscountAmount => Subtotal * (DiscountPercent / 100m);

        public decimal Total => Subtotal - DiscountAmount;

    }
}

/*• Use the MVC pattern. 
 * To do that, create a model class that stores 
 * the subtotal and discount percent 
 * and calculates the discount amount and total. 
 * Make sure to bind that model to the Razor view 
 * that displays the Price Quotation page shown above.*/
