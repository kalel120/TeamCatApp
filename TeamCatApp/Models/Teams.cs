using System.Collections.Generic;

namespace TeamCatApp.Models {
    public class Teams {
        public int Id { get; set; }
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public string TeamEmail { get; set; }

        public virtual IEnumerable<ApplicationUser> Users { get; set; }
    }
}