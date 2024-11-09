using CandidateHub.DTOs.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace CandidateHub.DTOs
{
    public class CandidateDto
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Phone]
        public string? Phone { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; } // Unique identifier
        [ContactTimeValidation]
        public TimeSpan? PreferredContactStartTime { get; set; }
        [ContactTimeValidation]
        public TimeSpan? PreferredContactEndTime { get; set; }

        [Url]
        public string? LinkedInProfile { get; set; } 

        [Url]
        public string? GitHubProfile { get; set; }

        public string? Comments { get; set; }
    }
}