namespace ContractMonthlyClaimSystem.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }
        public string Name { get; set; }
        public decimal TotalHours { get; set; }
        public decimal TotalPaid { get; set; }
    }
}