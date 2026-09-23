using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaB_Eduardo_Moraes_Viana_Questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizDesempenho = new double[4, 5];
            double somaTecnico = 0, mediaChamado = 0, maior=0, dia=1;

            for (int i = 0; i < matrizDesempenho.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDesempenho.GetLength(1); j++)
                {
                    Console.WriteLine($"Tecnico {i+1} digite o numeros de chamados atendidos no dia {j+1}: ");
                    matrizDesempenho[i, j] = Convert.ToDouble(Console.ReadLine());
                    somaTecnico = somaTecnico + matrizDesempenho[i, j];
                    if(matrizDesempenho[i,j] > maior)
                    {
                        maior = matrizDesempenho[i, j];

                    }

                
                }
                Console.WriteLine($"Maior número de chamados atendidos pelo tecnico {i + 1} é: {maior}");
                mediaChamado = somaTecnico / 5;
                Console.WriteLine($"Soma dos chamados do tecnico {i + 1}: {somaTecnico}");
                Console.WriteLine($"Media de chamados do tecnico {i + 1}: {mediaChamado}");
                if ( somaTecnico >= 40){
                    Console.WriteLine("META DE 40 CHAMADOS SEMANAIS ATINGIDOS!!!\nParabens, a equipe valia muito seu esforço \nAgradecimento de HelpNow");
                }
                else
                {
                    Console.WriteLine("META DE 40 CHAMADOS SEMANAIS NÂO ATINGIDOS!!! \nContinue se esforçando para alcançar a meta!\nAgradecimento de HelpNow");
                }
                maior = 0;
                mediaChamado = 0;
                somaTecnico = 0;
            }
            Console.ReadKey();
        }
    }
}
