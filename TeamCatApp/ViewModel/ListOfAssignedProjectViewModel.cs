using System.ComponentModel.DataAnnotations;

namespace TeamCatApp.ViewModel {
    public class ListOfAssignedProjectViewModel {
        [Display(Name = "Employee")]
        public string EmployeeName { get; set; }

        [Display(Name = "Project")]
        public string ProjectName { get; set; }

        [Display(Name = "Frequency")]
        public string ProjectFrequency { get; set; }

        [Display(Name = "Hours")]
        public string AssignedHour { get; set; }

        [Display(Name = "Date")]
        public string AssignedDate { get; set; }
    }
}