using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Models.Models
{
    [Table("usuario")]
    public partial class usuario
    {
        public usuario()
        {
        }
        [Key] public int usuarioid { get; set; }
        public int? educsenarontctfsindicatopoloid { get; set; }
        public int? empresaid { get; set; }
        public int? empresaidcolaborador { get; set; }
        public int? escritorioid { get; set; }
        public int? perfilid { get; set; }
        public int? pessoaid { get; set; }
        public int? pessoasindicatoid { get; set; }
        public int? regiaocobrancaid { get; set; }
        public int? regiaoid { get; set; }
        public int? setorid { get; set; }
        [Required][StringLength(60)] public string? nome { get; set; }
        [Required][StringLength(50)] public string? login { get; set; }
        [StringLength(50)] public string? loginad { get; set; }
        [Required][StringLength(50)] public string? senha { get; set; }
        [Required][StringLength(80)] public string? email { get; set; }
        [StringLength(100)] public string? comcopiapara { get; set; }
        public string? situacao { get; set; }
        public DateTime? dataadmissao { get; set; }
        [StringLength(100)] public string? home { get; set; }
        public string? tipo { get; set; }
        public bool permitelembrete { get; set; }
        public bool permitealertasonoro { get; set; }
        public bool responsavelsetor { get; set; }
        public bool geraprotocolo { get; set; }
        public bool feriasausente { get; set; }
        public string? permiteemaildocumento { get; set; }
        public bool bateponto { get; set; }
        public byte[]? informacaogeral { get; set; }
        public bool estagiario { get; set; }
        public byte[]? assinatura { get; set; }
        public float? multiplicadorcomprimentoaassinatura { get; set; }
        public float? multiplicadoralturaaassinatura { get; set; }
        public float? eixox { get; set; }
        public float? eixoy { get; set; }
        public int? perfilbeneficiario { get; set; }
        [StringLength(100)] public string? funcao { get; set; }
        public virtual empresa? empresa { get; set; }
        public virtual empresa? empresacolaborador { get; set; }
        public virtual pessoa? pessoa { get; set; }
        public virtual setor? setor { get; set; }
    }
}
