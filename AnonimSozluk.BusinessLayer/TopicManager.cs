using AnonimSozluk.DataAccessLayer.EntityFramework;
using AnonimSozluk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimSozluk.BusinessLayer
{
    public class TopicManager
    {
        Repository<Topic> repoTopic = new Repository<Topic>();

        public TopicManager()
        {
            repoTopic.List();
        }

        public List<Topic> GetTopics()
        {
            return repoTopic.List();
        }

        public List<Topic> GetTopicsReverse()
        {
            return repoTopic.List().OrderByDescending(x => x.CreatedDate).ToList();
        }
    }
}
