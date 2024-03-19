using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Application.DTOs
{
    public class TaskDTO
    {
        public TaskDTO() { }

        public string? responsavel_atual { get; set; }
        public string? setor_responsavel_atual { get; set; }
        public int id { get; set; }
        public string? numero { get; set; }
        public string? assunto { get; set; }
        public DateTime? data_criacao { get; set; }
        public DateTime? data_arquivamento {get;set;}
        public string? url { get; set; }
        public string? autor { get; set; }
        public string? demandante { get; set; }
        public string? setor_demandante { get; set; }
        public string? area {  get; set; }

    }
}
