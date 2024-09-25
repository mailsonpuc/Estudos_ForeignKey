using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Professor
{
    [Key]
    public int ProfessorId { get; set; }
    public string? Nome { get; set; }

    //Professor: Possui uma lista de alunos (Alunos), representando o relacionamento um para muitos.
    public List<Aluno>? Alunos { get; set; }
}



public class Aluno
{
    [Key]
    public int AlunoId { get; set; }
    public string? Nome { get; set; }

    //Aluno: Possui um ProfessorId como chave estrangeira e uma propriedade de navegação Professor para acessar o professor associado.
    [ForeignKey("ProfessorId")]
    public int ProfessorId { get; set; }

    //propriedade de navegação
    public Professor? Professor { get; set; }
}