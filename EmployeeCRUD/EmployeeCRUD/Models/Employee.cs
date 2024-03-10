using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("FirstName")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("LastName")]
        [Required]
        public string LastName { get; set;}
        public Double Salary { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
