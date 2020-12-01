using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamKnsrkOgrnApp.Data.Models
{
    public class Exam : Entity//sınavlar
    {
        public Article Article { get; set; }
        public List<Question> Questions { get; set; }
    }

    public class Article : Entity//Yazılar
    {
        public string Content { get; set; } // Article Content
        public string Title { get; set; } //Article Title
        public List<Exam> Exams { get; set; }

    }

    public class Question : Entity//sorular
    {
        public string Text { get; set; }
        public List<Choice> Choices { get; set; }
        public Exam Exam { get; set; }
        public int CorrectChoice { get; set; }
    }

    public class Choice: Entity//secenekler
    {
        public string Text { get; set; }
        public Question Question { get; set; }
    }

    public class TakenExam: Entity//girilen sınav
    {
        public string UserName { get; set; } // username normalde GUID
        public Exam Exam { get; set; }
        public DateTime CompletedAt { get; set; }
        public List<Answer> Answers{ get; set; }
    }

    public class Answer: Entity//ogrenci cevabları
    {

        public Question Question { get; set; }

        public Choice Choice { get; set; }//ogrenci cevabi
    }

    public class Entity
    {
        public int Id { get; set; }
    }
}
