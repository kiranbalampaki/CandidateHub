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

        public TimeSpan? PreferredContactStartTime { get; set; }

        public TimeSpan? PreferredContactEndTime { get; set; }

        [Url]
        public string? LinkedInProfile { get; set; } 

        [Url]
        public string? GitHubProfile { get; set; }

        public string? Comments { get; set; }
    }
}