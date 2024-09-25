public class Professor
{
    public int ProfessorId { get; set; }
    public string? Nome { get; set; }

    //Professor: Possui uma lista de alunos (Alunos), representando o relacionamento um para muitos.
    public List<Aluno>? Alunos { get; set; }
}



public class Aluno
{
    public int AlunoId { get; set; }
    public string? Nome { get; set; }

    //Aluno: Possui um ProfessorId como chave estrangeira e uma propriedade de navegação Professor para acessar o professor associado.
    public int ProfessorId { get; set; }

    //propriedade de navegação
    public Professor? Professor { get; set; }
}