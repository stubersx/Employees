namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //Composite Primary key and Foreign key for Department
        public int DepartmentID { get; set; }
        //Composite Primary key and Foreign key for Location
        public int LocationID { get; set; }

        //Navigation Properties
        public Department Department { get; set; } = null!;
        public Location Location { get; set; } = null!;
    }
}
