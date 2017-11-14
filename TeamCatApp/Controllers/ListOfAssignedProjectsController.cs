using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TeamCatApp.Models;
using TeamCatApp.ViewModel;

namespace TeamCatApp.Controllers {
    public class ListOfAssignedProjectsController : Controller {
        private readonly ApplicationDbContext _dbContext;

        public ListOfAssignedProjectsController() {
            _dbContext = new ApplicationDbContext();
        }

        // GET: ListOfAssignedProjects
        public ActionResult Index() {
            var assignedProjectsViewModel = new List<ListOfAssignedProjectViewModel>();

            var assignedProjects = _dbContext.AssignedProjects.ToList();

            foreach (var item in assignedProjects) {
                var task = new ListOfAssignedProjectViewModel();

                var specificUser = _dbContext.Users.Where(u => u.Id == item.UserId).Single();
                task.EmployeeName = specificUser.UserName;

                var specificProject = _dbContext.Projects.Where(p => p.Id == item.ProjectId).Single();
                task.ProjectName = specificProject.ProjectName;
                task.ProjectFrequency = specificProject.Frequency;

                task.AssignedHour = item.AssignedHour.ToString();
                task.AssignedDate = item.AssignedDate.ToShortDateString();

                assignedProjectsViewModel.Add(task);
            }

            return View(assignedProjectsViewModel);
        }
    }
}
