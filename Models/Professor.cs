using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string NomeDoProfessor { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}