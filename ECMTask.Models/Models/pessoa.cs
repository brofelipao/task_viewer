using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Models.Models
{
    [Table("pessoa")]
    public partial class pessoa
    {
        public pessoa()
        {
            ecmdocumento = new HashSet<ecmdocumento>();
            ecmdocumentotarefa = new HashSet<ecmdocumentotarefa>();
            ecmtramiteautor = new HashSet<ecmtramite>();
            ecmtramitedestinatario = new HashSet<ecmtramite>();
            setor = new HashSet<setor>();
            usuario = new HashSet<usuario>();
        }
        public int? admescolaridadeid { get; set; }
        public int? bancoid1 { get; set; }
        public int? bancoid2 { get; set; }
        public int? devolucaonotificacaomotivoid { get; set; }
        public int? empresaid { get; set; }
        public int? estadocivil { get; set; }
        public int? naturezajuridicaid { get; set; }
        public int? partidopoliticoid { get; set; }
        public int? pessoaclassificacaoid { get; set; }
        [Key] public int pessoaid { get; set; }
        public int? profissaoid { get; set; }
        public string? tipopessoa { get; set; }
        [StringLength(200)] public string? nome { get; set; }
        [StringLength(255)] public string? nomesocial { get; set; }
        [StringLength(30)] public string? siglanome { get; set; }
        [StringLength(14)] public string? cpfcnpj { get; set; }
        [StringLength(50)] public string? numerocei { get; set; }
        [StringLength(40)] public string? rginscricaoestadual { get; set; }
        public bool? rginscricaoestadualisento { get; set; }
        [StringLength(25)] public string? orgaoemissor { get; set; }
        public DateTime? dataexpedicao { get; set; }
        [StringLength(100)] public string? inscricaomunicipal { get; set; }
        [StringLength(100)] public string? nomefantasia { get; set; }
        public DateTime? datacadastro { get; set; }
        public Int64? cnaid { get; set; }
        public DateTime? datanascimento { get; set; }
        public string? sexo { get; set; }
        public int? auditoriausuairoid { get; set; }
        public DateTime? auditoriadatahora { get; set; }
        public string? origem { get; set; }
        [StringLength(20)] public string? telefoneresidencial { get; set; }
        [StringLength(20)] public string? telefonecelular { get; set; }
        [StringLength(20)] public string? telefonecomercial { get; set; }
        [StringLength(100)] public string? email1 { get; set; }
        [StringLength(100)] public string? email2 { get; set; }
        public DateTime? dataultimavisitafederacao { get; set; }
        public string? enviosms { get; set; }
        public string? envioemail { get; set; }
        public string? exportado { get; set; }
        [StringLength(20)] public string? ramalip { get; set; }
        [StringLength(20)] public string? fax { get; set; }
        [StringLength(200)] public string? naturalidade { get; set; }
        public string? naturalidadeuf { get; set; }
        [StringLength(200)] public string? nacionalidade { get; set; }
        [StringLength(255)] public string? nacionalidadeoutra { get; set; }
        [StringLength(20)] public string? codcontabilcliente { get; set; }
        [StringLength(20)] public string? codcontabilfornecedor { get; set; }
        public string? atualizadomanual { get; set; }
        public int? exercicioatualizacao { get; set; }
        public string? matriz { get; set; }
        public DateTime? dataatualizacaocadastral { get; set; }
        [StringLength(80)] public string? nomeconjuge { get; set; }
        public DateTime? datanascimentoconjuge { get; set; }
        [StringLength(100)] public string? site { get; set; }
        [StringLength(100)] public string? twitter { get; set; }
        [StringLength(100)] public string? facebook { get; set; }
        [StringLength(100)] public string? skype { get; set; }
        [StringLength(100)] public string? instagran { get; set; }
        [StringLength(100)] public string? linkedin { get; set; }
        [StringLength(20)] public string? agencia1 { get; set; }
        [StringLength(20)] public string? conta1 { get; set; }
        [StringLength(20)] public string? agencia2 { get; set; }
        [StringLength(20)] public string? conta2 { get; set; }
        [StringLength(5000)] public string? observacoes { get; set; }
        public bool atualizadoinfosystem { get; set; }
        [StringLength(255)] public string? nomemae { get; set; }
        [StringLength(255)] public string? nomepai { get; set; }
        public byte[]? foto { get; set; }
        [StringLength(255)] public string? arquivoidfoto { get; set; }
        public int? tempoexerceatividade { get; set; }
        [StringLength(255)] public string? numeromatriculasocial { get; set; }
        public int? tempofiliacaosindicatorural { get; set; }
        public string? certidaotipo { get; set; }
        [StringLength(50)] public string? certidaonumero { get; set; }
        [StringLength(20)] public string? certidaolivro { get; set; }
        [StringLength(20)] public string? certidaofolha { get; set; }
        public DateTime? certidaoemissao { get; set; }
        public string? certidaouf { get; set; }
        [StringLength(255)] public string? certidaomunicipio { get; set; }
        [StringLength(50)] public string? tituloeleitornumero { get; set; }
        [StringLength(20)] public string? tituloeleitorzona { get; set; }
        [StringLength(20)] public string? tituloeleitorsecao { get; set; }
        [StringLength(50)] public string? numeronis { get; set; }
        [StringLength(50)] public string? numeroinep { get; set; }
        [StringLength(20)] public string? telefoneemergencia { get; set; }
        [StringLength(255)] public string? contatoemergencia { get; set; }
        public virtual empresa empresa { get; set; }
        public virtual ICollection<ecmdocumento> ecmdocumento { get; set; }
        public virtual ICollection<ecmdocumento> ecmdocumentoautor { get; set; }
        public virtual ICollection<ecmdocumentotarefa> ecmdocumentotarefa { get; set; }
        public virtual ICollection<ecmtramite> ecmtramiteautor { get; set; }
        public virtual ICollection<ecmtramite> ecmtramitedestinatario { get; set; }
        public virtual ICollection<setor> setor { get; set; }
        public virtual ICollection<usuario> usuario { get; set; }
    }
}
