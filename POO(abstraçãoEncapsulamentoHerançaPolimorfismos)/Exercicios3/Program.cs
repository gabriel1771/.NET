
using Exercicios3;

Pessoa[] pessoas = new Pessoa[3] {  new Aluno("fulano"), new Aluno("ciclano") ,  new Professor("beltrano") };

((Aluno)pessoas[0]).Estudar();
((Aluno)pessoas[1]).Estudar();
((Professor)pessoas[2]).Ensinar();

Console.ReadKey();