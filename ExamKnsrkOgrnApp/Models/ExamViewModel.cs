using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamKnsrkOgrnApp.Models
{
    public class ExamViewModel
    {
        public ArticleViewModel Article { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
    }

    public class ArticleViewModel 
    {
        public string Content { get; set; } // Article Content
        public string Title { get; set; } //Article Title

    }
    public class ListItemArticle
    {
        public string Content { get; set; } // Article Content
        public string Title { get; set; } //Article Title

    }
    public class QuestionViewModel//sorular
    {
        public string Question { get; set; }
        public List<ChoiceViewModel> Choices { get; set; }
        public int CorrectChoice { get; set; }
    }

    public class ChoiceViewModel//secenekler
    {
        public string Text { get; set; }
        public string Name { get; set; }
    }
}
