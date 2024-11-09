using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace CandidateHub.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Candidate
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string? Phone { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public TimeSpan? PreferredContactStartTime { get; set; }
        public TimeSpan? PreferredContactEndTime { get; set; }
        public string LinkedInProfile { get; set; }
        public string GitHubProfile { get; set; }
        public string? Comments { get; set; }
    }
}
