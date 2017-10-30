using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCatApp.Models {
    public class AssignedProjects {
        public ApplicationUser User { get; set; }

        [Key]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public Projects Project { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProjectId { get; set; }

        public DateTime AssignedDate { get; set; }
        public int AssignedHour { get; set; }
    }
}