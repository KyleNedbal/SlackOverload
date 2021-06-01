using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.Common;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;

namespace SlackOverload.Models
{
    public class DAL
    {
        public static IDbConnection db;

        public static string CurrentUser;

        public static List <Answers> GetAllAnswers()
        {
            List<Answers> answers = db.Query<Answers>("select * from answers order by questionid").ToList();
            return answers;
        }
        public static List<Answers> GetCorrespondingAnswers(int id)
        {
            List<Answers> answers = db.Query<Answers>("select * from answers where questionid=" + id + " order by posted").ToList();
            return answers;
        }
        public static List<Answers> GetAllAnswersByQuestionID(int id)
        {
            List<Answers> answers = db.Query<Answers>("select * from answers where questionid=" + id + " order by id").ToList();
            return answers;
        }

        public static List<Questions> GetAllQuestionsByQuestionID()
        {
            List<Questions> qs = db.Query<Questions>("select * from questions order by id").ToList();
            return qs;
        }

        public static List<Questions> GetAllQuestionsByMostRecentPosted()
        {
            List<Questions> qs = db.Query<Questions>("select * from questions order by posted").ToList();
            return qs;
        }

        public static void CreateQuestion(Questions q)
        {
            db.Insert(q);
        }

        public static Questions GetIndividualQuestion(int id)
        {
            return db.Get<Questions>(id);
        }

        public static void EditQuestion(Questions q)
        {
            db.Update(q);
        }

        public static void DeleteQuestion(int id)
        {
            Questions q = db.Get<Questions>(id);
            List<Answers> answers = GetCorrespondingAnswers(id);
            if (q.username == DAL.CurrentUser || DAL.CurrentUser == "admin")
            {
                foreach (var ans in answers)
                {
                    db.Delete(ans);
                }
                
                db.Delete(q);
            }
        }

        public static void Insert(Questions q)
        {
            db.Insert(q);
        }

        public static void AddAnswer(Answers a)
        {
            db.Insert(a);
        }

        public static void DeleteAnswer(int id)
        {
            Answers ans = db.Get<Answers>(id);
            if (ans.username == DAL.CurrentUser || DAL.CurrentUser == "admin")
            {
                db.Delete(ans);
            }
        }

        public static Answers GetIndividualAnswer(int id)
        {
            return db.Get<Answers>(id);
        }

        public static void EditAnswer(Answers ans)
        {
            db.Update(ans);
        }

        //Need to finish
        /*public static void DeleteAnswer(Answers a)
        {

        }*/
    }
}
