using System.ComponentModel.DataAnnotations;

namespace CandidateHub.DTOs.CustomValidators
{
    public class ContactTimeValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var candidate = value as CandidateDto;

            if (candidate is null) return false;

            //Validation to make sure both are present if either one of them is present
            if ((candidate.PreferredContactStartTime.HasValue && !candidate.PreferredContactEndTime.HasValue) ||
            (!candidate.PreferredContactStartTime.HasValue && candidate.PreferredContactEndTime.HasValue))
            {
                return false;
            }

            //End time must be greater than start time
            if (candidate.PreferredContactStartTime.HasValue && candidate.PreferredContactEndTime.HasValue)
            {
                if (candidate.PreferredContactEndTime <= candidate.PreferredContactStartTime)
                {
                    return false;
                }
            }

            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"Both StartTime and EndTime are required when one is provided. EndTime needs to be greater than StartTime.";
        }
    }
}
