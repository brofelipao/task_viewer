using ECMTask.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Application.Interfaces
{
    public interface ITaskRepository
    {
        public List<TaskDTO> ObterTarefas(int last_ecmdocumentoid);
    }
}
