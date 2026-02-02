using System.ComponentModel.DataAnnotations;

namespace GBC_Ticketing.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public DateTime PurchaseDate { get; set; }

        [Required]
        public string GuestName { get; set; }

        [Required]
        public string GuestEmail { get; set; }

        public decimal TotalCost { get; set; }
    }
}
