

using System.Collections.Generic;
using System.Xml;

namespace SistemaEscolar
{
    public class Menu
    {

        private List<Aluno> novoAluno = new List<Aluno>();


        public void MenuPrincipal()
        {
            Console.WriteLine("DIGITE AS OPÇÕES DESEJADAS");
            Console.WriteLine("[1] - Cadastrar novo aluno");
            Console.WriteLine("[2] - Listar todos os alunos");
            Console.WriteLine("[3] - Mostrar apenas os aprovados");
            Console.WriteLine("[4] - Filtrar por média minima");
            Console.WriteLine("[5] - Motrar aluno com maior média");
            Console.WriteLine("[0] Sair");
            Console.Write("Opção: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: CadastrarAluno(); break;
                case 2: ListarTodosOsAlunos(); break;
                case 3: ListarAlunosAprovados(); break;
                case 4: FiltrarPormediaMinima(); break;
                case 5: MostrarAlunoComMaiorMedia(); break;
            }


        }

        public void ResetarMenu()
        {
            Thread.Sleep(1500);
            Console.Clear();
            MenuPrincipal();
        }
        public void CadastrarAluno()
        {
            Console.WriteLine("Dados do Aluno");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Matricula:");
            int matricula = int.Parse(Console.ReadLine());

            Aluno novoslunos = new Aluno(nome, matricula);


            for (int i = 0; i < 3; i++)
            {

                Console.Write($"Nota {i}: ");
                double nota = double.Parse(Console.ReadLine());
                novoslunos.Nota.Add(nota);


            }
            novoAluno.Add(novoslunos);
            Console.WriteLine("Aluno cadastrado com sucesso!");
            ResetarMenu();
        }

        public void ListarTodosOsAlunos()
        {


            Console.WriteLine("Listando todos os alunos");
            if (novoAluno.Count == 0)
            {
                Console.WriteLine("Nenhum Aluno encontrado");
            }
            else
            {
                Console.WriteLine("LISTA DE ALUNOS:");
                foreach (var alunos in novoAluno)
                {

                    Console.WriteLine("***********************");
                    Console.WriteLine(alunos);
                    Console.WriteLine("***********************");
                }
            }

            ResetarMenu();

        }


        public void ListarAlunosAprovados()
        {
            Console.WriteLine("LISTA DE APROVADOS");
            foreach (var aluno in novoAluno)
            {
                var aprovado = aluno.CalcularMedia();

                if (aprovado >= 7)
                {
                    Console.WriteLine(aluno);
                }
            }

            ResetarMenu();

        }


        public void FiltrarPormediaMinima()
        {
            foreach (var aluno in novoAluno)
            {
                var mediaMinima = aluno.CalcularMedia();
                if (mediaMinima >= 5 || mediaMinima <= 6)
                {
                    Console.WriteLine(aluno);
                }
            }
            ResetarMenu();
        }


        public void MostrarAlunoComMaiorMedia()
        {
            foreach (var aluno in novoAluno)
            {
                var maiorMedia = aluno.CalcularMedia();

                if(maiorMedia >= 9)
                {
                    Console.Write($"O Aluno com a maior nota é: {aluno.Nome} ");
                }

            }
            ResetarMenu();
        }
    }
}