using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Models.Models
{
    [Table("empresa")]
    public partial class empresa
    {
        public empresa()
        {
            ecmtramite = new HashSet<ecmtramite>();
            pessoa = new HashSet<pessoa>();
            setor = new HashSet<setor>();
            usuario = new HashSet<usuario>();
            usuariocolaborador = new HashSet<usuario>();
        }
        [Key] public int empresaid { get; set; }
        [StringLength(80)] public string? nome { get; set; }
        public int? pessoaiddiretor { get; set; }
        public string? situacao { get; set; }
        [StringLength(500)] public string? situacaoobservacao { get; set; }
        public byte[]? personalizacaologotipo { get; set; }
        public byte[]? personalizacaopapelparede { get; set; }
        public int? auditoriausuarioid { get; set; }
        public DateTime? auditoriadatahora { get; set; }
        [StringLength(14)] public string? cnpj { get; set; }
        [StringLength(200)] public string? razaosocial { get; set; }
        [StringLength(60)] public string? logradouro { get; set; }
        [StringLength(30)] public string? bairro { get; set; }
        [StringLength(60)] public string? cidade { get; set; }
        public string? uf { get; set; }
        public string? cep { get; set; }
        [StringLength(255)] public string? nomelogoemail { get; set; }
        public virtual ICollection<ecmtramite>? ecmtramite { get; set; }
        public virtual ICollection<pessoa>? pessoa { get; set; }
        public virtual ICollection<setor>? setor { get; set; }
        public virtual ICollection<usuario>? usuario { get; set; }
        public virtual ICollection<usuario>? usuariocolaborador { get; set; }
    }
}
