using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Models.Models
{
    [Table("ecmtramite")]
    public partial class ecmtramite
    {
        public ecmtramite()
        {
        }
        public int ecmdocumentoid { get; set; }
        public int? ecmprocessoid { get; set; }
        [Key] public int ecmtramiteid { get; set; }
        public int? empresaid { get; set; }
        public int? pessoaidautor { get; set; }
        public int? pessoaiddestinatario { get; set; }
        public DateTime? datahoracriacao { get; set; }
        public DateTime? datahoraleitura { get; set; }
        public DateTime? datahorarecebimento { get; set; }
        public int? auditoriausuarioid { get; set; }
        public DateTime? auditoriadatahora { get; set; }
        public int? usuarioidcriacao { get; set; }
        public int? usuarioidleitura { get; set; }
        public int? usuarioidrecebimento { get; set; }
        public int? setoridautor { get; set; }
        public int? setoriddestinatario { get; set; }
        public DateTime? prazoresposta { get; set; }
        public string? texto { get; set; }
        public int? situacao { get; set; }
        [StringLength(1)] public string? notificarenvio { get; set; }
        [StringLength(1)] public string? notificarrecebimento { get; set; }
        public int? ecmdocumentofluxosequencial { get; set; }
        public double? temporeceber { get; set; }
        public double? tempoencaminhar { get; set; }
        [StringLength(255)] public string? descricao { get; set; }
        public string? devolvido { get; set; }
        public DateTime? datahorabloqueadocontroleinterno { get; set; }
        public DateTime? datahoradesbloqueadocontroleinterno { get; set; }
        public virtual ecmdocumento? ecmdocumento { get; set; }
        public virtual empresa? empresa { get; set; }
        public virtual pessoa? pessoaautor { get; set; }
        public virtual pessoa? pessoadestinatario { get; set; }
        public virtual setor? setorautor { get; set; }
    }
}
