using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Models.Models
{
    [Table("ecmdocumento")]
    public partial class ecmdocumento
    {
        public ecmdocumento()
        {
            ecmtramite = new HashSet<ecmtramite>();
        }
        [Key] public int ecmdocumentoid { get; set; }
        public int? ecmdocumentoprioridadeid { get; set; }
        public int? ecmdocumentotipoid { get; set; }
        public int? ecmdominioidpermissaoportal { get; set; }
        public int? ecmrecebimentotipoid { get; set; }
        public int? ecmtemplatedocumentotipoid { get; set; }
        public int? educnaturezaprogramacaocentrocustoid { get; set; }
        public int? educprogramaespecialcentrocustoid { get; set; }
        public int? pessoaidinteressado { get; set; }
        public int? portalpastaid { get; set; }
        public int? setoridautor { get; set; }
        [StringLength(20)] public string? numerodocumento { get; set; }
        [StringLength(16)] public string? numeroprotocolo { get; set; }
        [StringLength(3000)] public string? assunto { get; set; }
        public DateTime? datacriacao { get; set; }
        public DateTime? auditoriadatahora { get; set; }
        public int? auditoriausuarioid { get; set; }
        public DateTime? dataprotocolo { get; set; }
        public string? arquivado { get; set; }
        public DateTime? dataarquivamento { get; set; }
        public string? observacaoarquivamento { get; set; }
        [StringLength(300)] public string? localarquivamento { get; set; }
        public int? empresaid { get; set; }
        public int? pessoaidautor { get; set; }
        public int? pessoaidprocedencia { get; set; }
        public string? elaborado { get; set; }
        public DateTime? datafimelaboracao { get; set; }
        [StringLength(150)] public string? assinatura { get; set; }
        public int? setoridinteressado { get; set; }
        public int? pessoaiddestino { get; set; }
        [StringLength(200)] public string? nomedestino { get; set; }
        [StringLength(100)] public string? funcaodestino { get; set; }
        public bool publico { get; set; }
        public string? status { get; set; }
        [StringLength(200)] public string? justificativacancelamento { get; set; }
        [StringLength(20)] public string? autorizado { get; set; }
        public string? despachar { get; set; }
        public string? despachadoobservacao { get; set; }
        public bool relatorioatividade { get; set; }
        public string? observacoes { get; set; }
        public int? usuarioidobservacoes { get; set; }
        public DateTime? datahoraobservacoes { get; set; }
        public bool verificadocontroleinterno { get; set; }
        public int? usuarioidverificadocontroleinterno { get; set; }
        public DateTime? datahoraverificadocontroleinterno { get; set; }
        public bool bloqueartramites { get; set; }
        public bool liberaralteracaodocumento { get; set; }
        [StringLength(100)] public string? materialgrupo { get; set; }
        public string? solicitacaoautomatica { get; set; }
        public bool? enviadototvs { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual pessoa pessoaautor { get; set; }
        public virtual setor setor { get; set; }
        public virtual setor setordemandante { get; set; }
        public virtual ecmdocumentotarefa ecmdocumentotarefa { get; set; }
        public virtual ICollection<ecmtramite> ecmtramite { get; set; }
    }
}
