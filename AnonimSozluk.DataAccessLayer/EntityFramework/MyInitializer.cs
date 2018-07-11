using AnonimSozluk.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimSozluk.DataAccessLayer.EntityFramework
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //Creating Topics
            for (int i = 0; i < 40; i++)
            {
                Topic topic = new Topic()
                {
                    Title = FakeData.TextData.GetSentence().Substring(0, FakeData.NumberData.GetNumber(10, 48)),
                    CreatedDate = FakeData.DateTimeData.GetDatetime(new DateTime(1999, 01, 01), DateTime.Now),

                };
                context.Topics.Add(topic);

                //Creating Comments
                for (int j = 0; j < FakeData.NumberData.GetNumber(5, 25); j++)
                {
                    Comment comment = new Comment()
                    {
                        CreatedDate = FakeData.DateTimeData.GetDatetime(topic.CreatedDate, DateTime.Now),
                        Text = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(5, 10)),
                        Ip = FakeData.TextData.GetSentence()
                    };
                    topic.Comments.Add(comment);
                }
            }

            context.SaveChanges();
        }
    }
}
