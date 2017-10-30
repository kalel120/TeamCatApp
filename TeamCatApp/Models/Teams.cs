using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamCatApp.Models {
    public class Teams {
        public int Id { get; set; }
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public string TeamEmail { get; set; }

        public virtual IEnumerable<ApplicationUser> Users { get; set; }
    }
}