using AishaStudyGroupp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AishaStudyGroupp.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            List<StudyMembers> members = new List<StudyMembers>
            {
                new StudyMembers { StudentNumber = "u23624800", Name = "Aisha", Surname = "Mohamad", EmailAddress = "u23624800@tuks.co.za" },
                new StudyMembers { StudentNumber = "u23735911", Name = "Nicky", Surname = "Naidoo", EmailAddress = "u23735911@tuks.co.za" },
                new StudyMembers { StudentNumber = "u23846022", Name = "Ricky", Surname = "Bore", EmailAddress = "u23846022@tuks.co.za" },
                new StudyMembers { StudentNumber = "u23957133", Name = "Dicky", Surname = "Digson", EmailAddress = "u23957133@tuks.co.za" },
                new StudyMembers { StudentNumber = "u23068244", Name = "Dawn", Surname = "Mtsatse", EmailAddress = "u23068244@tuks.co.za" },
            };
            return View(members);
        }
    }
}