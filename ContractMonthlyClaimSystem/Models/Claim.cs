using System;

namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int LecturerID { get; set; }
        public string LecturerName { get; set; } // For display
        public decimal Hours { get; set; }
        public decimal Amount { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Status { get; set; }
    }
}