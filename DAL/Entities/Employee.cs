using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        [Column(TypeName = "varchar(250)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        [Column(TypeName = "varchar(250)")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Select Department")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
