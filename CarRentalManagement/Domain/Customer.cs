namespace CarRentalManagement.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? DrivingLisence { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }
    }
}
