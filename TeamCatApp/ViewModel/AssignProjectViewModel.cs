using TeamCatApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TeamCatApp.ViewModel {
    public class AssignProjectViewModel {
        [Required(ErrorMessage = "* Team selection is required")]
        public IEnumerable<Teams> Teams { get; set; }

        [Display(Name = "Employees")]
        [Required(ErrorMessage = "* Employee Selection is required")]
        public IEnumerable<ApplicationUser> Users { get; set; }

        [Required(ErrorMessage = "* Project Selection is required")]
        public IEnumerable<Projects> Projects { get; set; }

        [Display(Name = "Project Fequency")]
        [Required(ErrorMessage = "* Select Project Frequency")]
        public IEnumerable<string> Frequencies { get; set; }

        //Added for model binding
        public string EmployeeName { get; set; }
        public string ProjectName { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "* Select a date ")]
        public string AssignedDate { get; set; }

        [Display(Name = "Hour")]
        [Range(1, 8, ErrorMessage = "Enter hours between [0 - 8]")]
        public int AssignedHour { get; set; }

        public string Frequency { get; set; }
    }
}