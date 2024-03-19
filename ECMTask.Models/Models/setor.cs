using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Models.Models
{
    [Table("setor")]
    public partial class setor
    {
        public setor()
        {
            ecmdocumento = new HashSet<ecmdocumento>();
            setorFilhos = new HashSet<setor>();
            usuario = new HashSet<usuario>();
        }
        public int? empresaid { get; set; }
        public int? pessoaiddiretor { get; set; }
        [Key] public int setorid { get; set; }
        public int? setoridgestor { get; set; }
        [StringLength(150)] public string? nome { get; set; }
        public string? situacao { get; set; }
        public string? atendimento { get; set; }
        public string? geraprotocolo { get; set; }
        [StringLength(20)] public string? cor { get; set; }
        [StringLength(255)] public string? nomeunidade { get; set; }
        [StringLength(20)] public string? codigowkradar { get; set; }
        public string? areasenar { get; set; }
        public bool diretoria { get; set; }
        public virtual empresa empresa { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual setor setorgestor { get; set; }
        public virtual ICollection<ecmdocumento> ecmdocumento { get; set; }
        public virtual ICollection<ecmdocumento> ecmdocumentodemandante { get; set; }
        public virtual ICollection<setor> setorFilhos { get; set; }
        public virtual ICollection<usuario> usuario { get; set; }
        public virtual ICollection<setorarea> setorarea { get; set; }
        public virtual ICollection<ecmtramite> ecmtramite { get; set; }
    }
}
