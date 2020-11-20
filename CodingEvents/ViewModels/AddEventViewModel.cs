using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(50, MinimumLength=3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description must be less than 500 words.")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }
    }
}
