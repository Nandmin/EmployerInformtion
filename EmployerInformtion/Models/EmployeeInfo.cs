using System;
using System.Collections.Generic;

#nullable disable

namespace EmployerInformtion.Models
{
    public partial class EmployeeInfo
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal? Salary { get; set; }
        public string DepartmentName { get; set; }
    }
}
