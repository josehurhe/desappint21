using System.ComponentModel.DataAnnotations;

namespace p20_blazorcrud.Data
{
    public class Employee
    {
        public Employee(){}
        public Employee(string EmployeeName, string Gender, string City, string Designation){
            this.EmployeeName = EmployeeName;
            this.Gender = Gender;
            this.City = City;
            this.Designation = Designation;
        }
        [Key]
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Designation { get; set; }
    }
}