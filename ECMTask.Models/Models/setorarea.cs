using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Models.Models
{
    [Table("setorarea")]
    public class setorarea
    {
        public int setorareaid { get; set; }
        public int? setorid { get; set; }
        public string? descricao { get;set; }
        public ICollection<ecmdocumentotarefa>? ecmdocumentotarefa { get; set; }
        public setor? setor { get; set; }
    }
}
