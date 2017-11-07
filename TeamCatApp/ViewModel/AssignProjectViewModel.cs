using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamCatApp.Models;

namespace TeamCatApp.ViewModel {
    public class AssignProjectViewModel {
        public int Team { get; set; }
        public IEnumerable<Teams> Teams { get; set; }
        public IEnumerable<ApplicationUser> Users { get; set; }
        public string Date { get; set; }
        public int Project { get; set; }
        public IEnumerable<Projects> Projects { get; set; }
        public IEnumerable<string> Frequencies { get; set; }

        //Added for model binding
        public string EmployeeName { get; set; }
        public string ProjectName { get; set; }
        public string AssignedHour { get; set; }
        public string Frequency { get; set; }
    }
}