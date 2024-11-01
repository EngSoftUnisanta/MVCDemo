using MVCDemo.Models;

namespace MVCDemo.Services
{
    public class Repositorio
    {
        private List<Aluno> Alunos = new List<Aluno>();


        public Repositorio()
        {
            Alunos.Add(new Aluno { RA = "123", Nome = "João" });
            Alunos.Add(new Aluno { RA = "456", Nome = "Maria" });
                

        }

        public List<Aluno> GetAlunos()
        {
            return Alunos;
        }

        public Aluno GetAluno(string ra)
        {
            return Alunos.FirstOrDefault(a => a.RA == ra);
        }

        public void AddAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        
        public void UpdateAluno(Aluno aluno)
        {
            var alunoExistente = Alunos.FirstOrDefault(a => a.RA == aluno.RA);
            if (alunoExistente != null)
            {
                alunoExistente.Nome = aluno.Nome;
            }
        }

        public void DeleteAluno(string ra)
        {
            var aluno = Alunos.FirstOrDefault(a => a.RA == ra);
            if (aluno != null)
            {
                Alunos.Remove(aluno);
            }
        }
    }
}
