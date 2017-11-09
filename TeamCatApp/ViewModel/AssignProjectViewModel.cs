using System;
using TeamCatApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TeamCatApp.ViewModel {
    public class AssignProjectViewModel {
        [Required(ErrorMessage = "This is required")]
        public IEnumerable<Teams> Teams { get; set; }

        [Display(Name = "Employees")]
        [Required(ErrorMessage = "This is required")]
        public IEnumerable<ApplicationUser> Users { get; set; }

        [Required(ErrorMessage = "This is required")]
        public IEnumerable<Projects> Projects { get; set; }

        [Display(Name = "Project Frequency")]
        [Required(ErrorMessage = "This is required")]
        public IEnumerable<string> Frequencies { get; set; }

        //Added for model binding
        public string EmployeeName { get; set; }
        public string ProjectName { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "This is required")]
        public string AssignedDate { get; set; }

        [Range(1, 8, ErrorMessage = "Please enter hour between 0 to 8")]
        public int AssignedHour { get; set; }

        public string Frequency { get; set; }
    }
}