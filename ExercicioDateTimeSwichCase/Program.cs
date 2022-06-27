using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDateTimeSwichCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comentarios

            // RA: 6322036
            // Vinícius Hernandes Pinheiro

            {
                /* variavel "data" dd/mm/aaaa (Brasil)
                                   mm/dd/aaaa (EUA)

                   trabalhar com data e depois converter data


                Exercicio:

                - 1º peça a data para o usuario
                - 2º mostre o mes data em extenso

                Convert.ToDataTime(data);

                int mes = Data.month;

                int dia = Data.day;

                int ano = Data.year;

                -----------------------
               
                string MesExtenso;

                switch(mes)
                {
                   case1:
                        MesExtenso = "Janeiro"
                        break;

                   case2:
                        MesExtenso = "Fevereiro"
                        break;

                .
                .
                .

                }

                int numero1 = int.Parse(Console.ReadLine());

                DateTime dataAtual = Convert.ToDateTime(Console.ReadLine());
                */
            }

            Console.WriteLine("Digite uma data: ");
            var DataEscolhida = Convert.ToDateTime(Console.ReadLine());




            int dia = DataEscolhida.Day;   // Sepera o dia da variavel "DataEscolhida"

            int mes = DataEscolhida.Month; // Sepera o mes da variavel "DataEscolhida"

            int ano = DataEscolhida.Year;  // Sepera o ano da variavel "DataEscolhida"

            var diasemana = DataEscolhida.DayOfWeek;



            String MesExtenso = null;

            switch (mes)
            {
                case 1:
                    MesExtenso = "Janeiro";
                    break;

                case 2:
                    MesExtenso = "Fevereiro";
                    break;

                case 3:
                    MesExtenso = "Março";
                    break;

                case 4:
                    MesExtenso = "Abril";
                    break;

                case 5:
                    MesExtenso = "Maio";
                    break;

                case 6:
                    MesExtenso = "junho";
                    break;

                case 7:
                    MesExtenso = "Julho";
                    break;

                case 8:
                    MesExtenso = "Agosto";
                    break;

                case 9:
                    MesExtenso = "Setembro";
                    break;

                case 10:
                    MesExtenso = "Outubro";
                    break;

                case 11:
                    MesExtenso = "Novembro";
                    break;

                case 12:
                    MesExtenso = "Dezembro";
                    break;
            }



            Console.WriteLine(dia + " de " + MesExtenso + " de " + ano);
        }
    }
}
