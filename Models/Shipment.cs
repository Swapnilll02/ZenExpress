using System;
using System.ComponentModel.DataAnnotations;

namespace CourierService.Models
{
    public class Shipment
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 100)]
        public int Age { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string SenderAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PickupDate { get; set; }

        [Required]
        public string ItemsToDeliver { get; set; }

        [Required]
        public string ReceiverAddress { get; set; }

        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Package weight must be greater than 0.")]
        public double PackageWeight { get; set; }

        [Required]
        public string DeliveryOption { get; set; }  // "One Day Delivery" or "Standard Delivery"

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double TotalAmount { get; set; }  // Calculated based on weight and delivery type
    }
}
