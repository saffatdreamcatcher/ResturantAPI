namespace Core.ViewModels
{
    public class EmployeeResource
    {
        public int? Id { get; set; }
        public string Designation { get; set; }
        public DateTime JoinDate { get; set; }
        public double AmountSold { get; set; }
        public UserResource UserResource { get; set; }
    }
}
