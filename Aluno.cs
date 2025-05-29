

using System.Globalization;

namespace SistemaEscolar
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public List<double> Nota { get; set; } = new List<double>();


        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
           
        }
        public Aluno(string nome, int matricula, List<double> nota)
        {
            Nome = nome;
            Matricula = matricula;
            Nota = nota;
        }

        public double CalcularMedia()
        {
           return Nota.Count < 7 ? Nota.Average() : 0;
          
        }


        public override string ToString()
        {
            return "Nome: "
                   + Nome
                   + " , Matricula: "
                   + CalcularMedia().ToString("f2",CultureInfo.InvariantCulture);
        }

    }


}

