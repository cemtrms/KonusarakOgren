using ExamKnsrkOgrnApp.Data.Models;
using ExamKnsrkOgrnApp.Data.Models.Const;
using ExamKnsrkOgrnApp.Helpers;
using ExamKnsrkOgrnApp.Models;
using ExamKnsrkOgrnApp.SQLite;
using ExampleProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ExamKnsrkOgrnApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly SQLiteDBContext _context;

        public HomeController(IConfiguration configuration, SQLiteDBContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public IActionResult Index(string filter, int pageSize, int currentPage)
        {
            if (currentPage <= 0) currentPage = 1;
            if (pageSize <= 0) pageSize = 10;

            var articles = HttpClientHelper.GetlastFiveArticles(_configuration.GetValue<string>("MySettings:URLConnection"));
            var filteredMonitoringTasks = articles
                .Where(p =>
                 (filter == null
                        || p.Title.Contains(filter)))
                .ToList();

            var productsInPage = filteredMonitoringTasks
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new ArticleTaskDto { Title = p.Title }).ToList();

            return View(new PagingModel<ArticleTaskDto>(filter, filteredMonitoringTasks.Count, currentPage, productsInPage));
        }

        public ActionResult Create(string title)
        {
            ExamViewModel model = GetModelByTitle(title);
            return PartialView("_InsertQuestion", model);
        }

        private ExamViewModel GetModelByTitle(string title)
        {
            string url = _configuration.GetValue<string>("MySettings:URLConnection");
            IEnumerable<SelectListItem> items, items1;
            BindDropDownList(title, out items, out items1, url);
            ExamViewModel model = CreateModel(title, items, items1);
            return model;
        }

        private ExamViewModel CreateModel(string title, IEnumerable<SelectListItem> items, IEnumerable<SelectListItem> items1)
        {
            var model = new ExamViewModel();
            ViewBag.ArticleTitle = items;
            ViewBag.Choices = items1;
            model.Article = new ArticleViewModel { Title = title, Content = GetArticleByTitle(title).Content };
            ArticleViewModel article = new ArticleViewModel();
            model.Questions = new List<QuestionViewModel>();
            for (int i = 0; i < 5; i++)
            {
                model.Questions.Add(new QuestionViewModel());
            }

            foreach (var item in model.Questions)
            {
                item.Choices = new List<ChoiceViewModel>();

                item.Choices.Add(new ChoiceViewModel { Name = "A" });
                item.Choices.Add(new ChoiceViewModel { Name = "B" });
                item.Choices.Add(new ChoiceViewModel { Name = "C" });
                item.Choices.Add(new ChoiceViewModel { Name = "D" });

            }

            return model;
        }

        private static void BindDropDownList(string title, out IEnumerable<SelectListItem> items, out IEnumerable<SelectListItem> items1, string url)
        {
            var articles = HttpClientHelper.GetlastFiveArticles(url);
            items =
        from value in articles

        select new SelectListItem

        {

            Text = value.Title.ToString(),

            Value = value.Title.ToString(),

            Selected = value.Title == title,

        };
            items1 = new SelectListItem[] { new SelectListItem { Text = ChoiceValue.ASıkkı, Value = ChoiceValue.ASıkkı, Selected = true }, new SelectListItem { Text = ChoiceValue.BSıkkı, Value = ChoiceValue.BSıkkı, Selected = false }, new SelectListItem { Text = ChoiceValue.CSıkkı, Value = ChoiceValue.CSıkkı, Selected = false }, new SelectListItem { Text = ChoiceValue.DSıkkı, Value = ChoiceValue.DSıkkı, Selected = false } };
        }

        [HttpPost]
        public ActionResult Create(ExamViewModel exam)
        {
            //_context.Exams.Add();
            _context.SaveChanges();
            var data = _context.Exams.ToList();
            return PartialView("_InsertQuestion");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public JsonResult Bind(string title)
        {
            var article = GetArticleByTitle(title);
            return Json(new
            {
                response = article.Content
            });
        }

        private ArticlesViewModel GetArticleByTitle(string title)
        {
            return HttpClientHelper.GetlastFiveArticles(_configuration.GetValue<string>("MySettings:URLConnection")).First(p => p.Title == title);
        }
    }
}
