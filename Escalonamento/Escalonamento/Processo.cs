using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonamento
{
    public class Processo
    {
        public string NomeProcesso { get; set; }
        public int Prioridade { get; set; }
        public int TempoExecucao { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public int Espera { get; set; }
        public int Id { get; set; }
        public bool Ativo { get; set; }
    }
}
