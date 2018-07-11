using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimSozluk.Entities
{
    [Table("Comments")]
    public class Comment : EntityBase
    {
        public string Ip { get; set; }

        [Required]
        public string Text { get; set; }

        public virtual Topic Topic { get; set; }
    }
}
