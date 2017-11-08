using System;
using System.Collections.Generic;
using TeamCatApp.Models;

namespace TeamCatApp.ViewModel {
    public class AssignProjectViewModel {
        public IEnumerable<Teams> Teams { get; set; }
        public IEnumerable<ApplicationUser> Users { get; set; }
        public IEnumerable<Projects> Projects { get; set; }
        public IEnumerable<string> Frequencies { get; set; }

        //Added for model binding
        public string EmployeeName { get; set; }
        public string ProjectName { get; set; }
        public DateTime AssignedDate { get; set; }
        public string AssignedHour { get; set; }
        public string Frequency { get; set; }
    }
}