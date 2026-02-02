using System.ComponentModel.DataAnnotations;

namespace GBC_Ticketing.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date and time is required")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Ticket price is required")]
        [Range(0.01, 10000, ErrorMessage = "Ticket price must be greater than 0")]
        public decimal TicketPrice { get; set; }

        [Required(ErrorMessage = "Available tickets is required")]
        [Range(1, 10000, ErrorMessage = "Available tickets must be at least 1")]
        public int AvailableTickets { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
