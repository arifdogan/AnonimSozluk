using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimSozluk.Entities
{
    [Table("Topics")]
    public class Topic : EntityBase
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public Topic()
        {
            Comments = new List<Comment>();
        }
    }
}
