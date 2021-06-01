using Microsoft.AspNetCore.Mvc;
using SlackOverload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackOverload.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            //List<Answers> answers = DAL.GetAllAnswersByQuestionID();
            //ViewBag.answers = answers;
            List<Questions> qs = DAL.GetAllQuestionsByMostRecentPosted();
            foreach (Questions q in qs)
            {
                List<Answers> answers = DAL.GetAllAnswersByQuestionID(q.id);
                if (answers.Count > 0)
                {
                    q.status = 1;
                }
                else
                {
                    q.status = 0;
                }
                DAL.EditQuestion(q);
            }

            qs = DAL.GetAllQuestionsByMostRecentPosted();
            return View(qs);
        }

        public IActionResult CreateForm(string username)
        {
            DAL.CurrentUser = username;
            return View(username);
        }

        [HttpPost]
        public IActionResult Create(Questions q)
        {
            DAL.CreateQuestion(q);
            return RedirectToAction("Index");
        }

        public IActionResult EditForm(int id)
        {
            Questions q = DAL.GetIndividualQuestion(id);
            return View(q);
        }

        [HttpPost]
        public IActionResult Edit(Questions q)
        {
            DAL.EditQuestion(q);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteForm(int id)
        {
            Questions q = DAL.GetIndividualQuestion(id);
            return View(q);
        }

        public IActionResult Delete(int id)
        {
            DAL.DeleteQuestion(id);
            return RedirectToAction("Index");
        }

        public IActionResult ViewQuestion(int id)
        {
            Questions q = DAL.GetIndividualQuestion(id);
            List<Answers> answers = DAL.GetCorrespondingAnswers(id);
            ViewBag.answers = answers;
            return View(q);
        }

        public IActionResult CreateAnswerForm(int id)
        {
            Questions q = DAL.GetIndividualQuestion(id);
            return View(q);
        }

        public IActionResult CreateAnswer(Answers ans)
        {
            DAL.AddAnswer(ans);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAnswerForm(int id)
        {
            Answers ans = DAL.GetIndividualAnswer(id);
            return View(ans);
        }

        public IActionResult DeleteAnswer(int id)
        {
            DAL.DeleteAnswer(id);
            return RedirectToAction("Index");
        }

        public IActionResult EditAnswerForm(int id)
        {
            Answers ans = DAL.GetIndividualAnswer(id);
            Questions q = DAL.GetIndividualQuestion(ans.questionid);
            ViewBag.question = q;
            return View(ans);
        }

        [HttpPost]
        public IActionResult EditAnswer(Answers a)
        {
            DAL.EditAnswer(a);
            return RedirectToAction("Index");
        }

        public IActionResult Search(string userSearch)
        {
            List<Questions> qs = DAL.GetAllQuestionsByQuestionID();
            List<Answers> ans = DAL.GetAllAnswers();
            List<Questions> foundQuestions = new List<Questions>();


            foreach (var q in qs)
            {
                string titles = q.title;
                string usernames = q.username;
                string details = q.detail;

                if (titles.Split(' ').Contains(userSearch) || usernames.Split(' ').Contains(userSearch) || details.Split(' ').Contains(userSearch))
                {
                    foundQuestions.Add(q);
                }
            }
            foreach (var a in ans)
            {
                string details = a.detail;
                string usernames = a.username;

                if (details.Split(' ').Contains(userSearch) || usernames.Split(' ').Contains(userSearch))
                {
                    foundQuestions.Add(DAL.GetIndividualQuestion(a.id));
                }
            }
            if (foundQuestions.Count > 0)
            {
                return View(foundQuestions);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
