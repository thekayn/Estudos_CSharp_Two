using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:"Kayn", sobrenome:"Brutal");
// p1.Nome = "Kayn";
// p1.Sobrenome = "Brutal";
//p1.Idade = 20;
//p1.Apresentar();

Pessoa p2 = new Pessoa(nome:"Pablo", sobrenome:"Reis");
// p2.Nome = "Pablo";
// p2.Sobrenome = "Reis";

Pessoa p3 = new Pessoa(nome:"Mateus", sobrenome:"Wotan");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.adicionarAluno(p1);
cursoDeIngles.adicionarAluno(p2);
cursoDeIngles.adicionarAluno(p3);
cursoDeIngles.listarAlunos();
Console.WriteLine(cursoDeIngles.obterQuantidadeDeAlunosMatriculados());
