namespace WebAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }

        public EmpClass Class { get; set; } = EmpClass.Day;
    }
}