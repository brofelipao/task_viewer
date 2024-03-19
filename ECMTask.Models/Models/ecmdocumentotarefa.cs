using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Models.Models
{
    [Table("ecmdocumentotarefa")]
    public partial class ecmdocumentotarefa
    {
        public ecmdocumentotarefa()
        {
        }
        public int demandantepessoaid { get; set; }
        public int? ecmatendimentotipoid { get; set; }
        [Key][DatabaseGenerated(DatabaseGeneratedOption.None)] public int? ecmdocumentoidtarefa { get; set; }
        public int? setorareaid { get; set; }
        public DateTime? datadesejada { get; set; }
        public DateTime? datainicio { get; set; }
        public DateTime? datafim { get; set; }
        public string? tarefadescricao { get; set; }
        public bool demandantepontual { get; set; }
        public decimal? custoestimado { get; set; }
        public decimal? custorealizado { get; set; }
        public int? pesoprioridade { get; set; }
        public bool prioridadealterada { get; set; }
        [StringLength(255)] public string? tag { get; set; }
        public int? imagetech_ticketid { get; set; }
        public DateTime? dataenvioparafabrica { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual ecmdocumento ecmdocumento { get; set; }
        public virtual setorarea setorarea { get; set; }
    }
}
