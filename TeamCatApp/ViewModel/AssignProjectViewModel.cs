using System;
using TeamCatApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TeamCatApp.ViewModel {
    public class AssignProjectViewModel {
        public IEnumerable<Teams> Teams { get; set; }

        [Display(Name = "Employees")]
        public IEnumerable<ApplicationUser> Users { get; set; }

        public IEnumerable<Projects> Projects { get; set; }

        [Display(Name = "Project Frequency")]
        public IEnumerable<string> Frequencies { get; set; }

        //Added for model binding
        public string EmployeeName { get; set; }
        public string ProjectName { get; set; }
        public string AssignedDate { get; set; }
        public int AssignedHour { get; set; }
        public string Frequency { get; set; }
    }
}