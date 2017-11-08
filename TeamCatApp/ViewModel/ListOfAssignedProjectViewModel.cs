using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamCatApp.ViewModel {
    public class ListOfAssignedProjectViewModel {
        public string EmployeeName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectFrequency { get; set; }
        public string AssignedHour { get; set; }
        public string AssignedDate { get; set; }
    }
}