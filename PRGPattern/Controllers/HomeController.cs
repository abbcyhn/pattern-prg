namespace PRGPattern.Controllers
{
    using ViewModels;
    using Attributes;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Standart()
        {
            var model = new UserViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Standart(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult PRG1()
        {
            var model = new UserViewModel();

            var modelState = TempData["ModelState"] as ModelStateDictionary;
            if (modelState != null)
            {
                ModelState.Merge(modelState);
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult PRG1(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ModelState"] = ModelState;
                return RedirectToAction("PRG1");
            }

            return RedirectToAction("Index");
        }



        [HttpGet]
        [ImportModelState]
        public ActionResult PRG2()
        {
            var model = new UserViewModel();
            return View(model);
        }

        [HttpPost]
        [ExportModelState]
        public ActionResult PRG2(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("PRG2");
            }

            return RedirectToAction("Index");
        }
    }
}