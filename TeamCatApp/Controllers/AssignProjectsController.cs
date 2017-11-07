using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TeamCatApp.Models;
using TeamCatApp.ViewModel;

namespace TeamCatApp.Controllers {
    public class AssignProjectsController : Controller {
        private readonly ApplicationDbContext _dbContext;

        public AssignProjectsController() {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Index() {

            var assignProjectViewModel = new AssignProjectViewModel {
                Teams = _dbContext.Teams.ToList(),
                Frequencies = _dbContext.Projects.Select(x => x.Frequency).Distinct().ToList()
            };
            return View(assignProjectViewModel);
        }

        public JsonResult GetUsersByTeamId(int teamId) {
            List<ApplicationUser> users = _dbContext.Users.Where(u => u.TeamId == teamId).ToList();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetProjectsByFrequency(string frequncy) {
            List<Projects> projectsByFrequency = _dbContext.Projects.Where(p => p.Frequency == frequncy).ToList();
            return Json(projectsByFrequency, JsonRequestBehavior.AllowGet);
        }

        // Test >> Submitting table rows to controller
        [HttpPost]
        public JsonResult SaveAssignedProjects(List<AssignProjectViewModel> assignedProjects) {
            return Json(assignedProjects, JsonRequestBehavior.AllowGet);
        }
    }
}