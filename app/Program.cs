using Microsoft.EntityFrameworkCore;

using var context = new AppContext();

var professor = new Professor { Nome = "João da Silva" };
var aluno1 = new Aluno { Nome = "Maria", Professor = professor };
var aluno2 = new Aluno { Nome = "Pedro", Professor = professor };
var aluno3 = new Aluno { Nome = "Mailson", Professor = professor };
var aluno4 = new Aluno { Nome = "Vitoria", Professor = professor };

professor.Alunos = new List<Aluno> { aluno1, aluno2, aluno3, aluno4 };

context.Professores?.Add(professor);
await context.SaveChangesAsync();