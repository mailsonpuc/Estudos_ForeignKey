using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string NomeDoAluno { get; set; }
        public int ProfessorId { get; set; } // Chave estrangeira
        public Professor Professor { get; set; }
    }
}