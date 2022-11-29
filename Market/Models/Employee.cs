namespace Market.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }
        
        public string BirthDate { get; set; }

        public string Gender { get; set; }

        public string Nationality { get; set; }
        public string Address { get; set; }
        public virtual List<Order> orders { get; set; }
    }
}
