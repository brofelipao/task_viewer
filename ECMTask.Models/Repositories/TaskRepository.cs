using ECMTask.Application.DTOs;
using ECMTask.Application.Interfaces;
using ECMTask.Models.Context;
using ECMTask.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMTask.Models.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        FoccusDbContext db;
        public TaskRepository(FoccusDbContext db)
        {
            this.db = db;
        }

        public List<TaskDTO> ObterTarefas(int last_ecmdocumentoid)
        {

            var tarefas = db.ecmdocumento
                .Include(t => t.ecmtramite).ThenInclude(t => t.pessoaautor)
                .Include(t => t.ecmtramite).ThenInclude(t => t.setorautor)
                .Include(t => t.ecmdocumentotarefa).ThenInclude(d => d.setorarea).ThenInclude(sa => sa.setor)
                .Include(t => t.setordemandante)
                .Where(d => d.ecmdocumentotipoid == 46 && d.ecmdocumentotarefa!.setorarea!.setor.nome == "TI" && d.ecmdocumentoid > last_ecmdocumentoid)
                .Select(c => new TaskDTO { 
                    responsavel_atual = c.ecmtramite!.OrderBy(c => c.ecmtramiteid).LastOrDefault()!.pessoaautor!.nome,
                    setor_responsavel_atual = c.ecmtramite!.OrderBy(c => c.ecmtramiteid).LastOrDefault()!.setorautor!.nome,
                    id = c.ecmdocumentoid,
                    numero = c.numerodocumento,
                    assunto = c.assunto,
                    data_criacao = c.datacriacao,
                    data_arquivamento = c.dataarquivamento,
                    url = $"http://intranet.senarms.org.br/ecm/Tarefa/Detalhar/{c.ecmdocumentoid}",
                    autor = c.pessoaautor!.nome,
                    demandante = c.pessoa!.nome,
                    setor_demandante = c.setordemandante!.nome,
                    area = c.ecmdocumentotarefa!.setorarea!.descricao
                }).ToList();

            return tarefas;
        }
    }
}
