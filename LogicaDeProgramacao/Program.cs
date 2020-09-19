using System;
using System.Collections.Generic;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BuscarSeculoPorAno
            //Dado um ano inicial como parâmetro, a logica retorna o seculo conrrespondente ao ano informado
            //Console.WriteLine("Informe um ano!");
            //var ano = Convert.ToInt16(Console.ReadLine());
            //var seculo = Logica.BuscarSeculoPorAno(ano);
            //Console.WriteLine($"O Século conrrespondente é:{seculo}");
            #endregion

            #region GeradorDeCartelas
            //Logica para gerar cartelas de sorteio
            //List<string> numerosCriados = new List<string>();

            //Console.WriteLine("================= Cartelas de sorteio ================\n");

            //int i = 0;

            //numerosCriados = Logica.GeradorDeCartelas();
            //foreach (var numero in numerosCriados)
            //{
            //    Console.Write("{0,8}", numero);
            //    if (i % 4 == 0) Console.WriteLine();
            //    i++;
            //}
            #endregion

            #region BuscaMenorNumeroDeNotas
            //Dado um valor, a logica informa o menor numero de notas posiveis 
            //Console.WriteLine("Entre com o valor");
            //int entrada = Convert.ToInt16(Console.ReadLine());
            //int cem = 0, cinquenta = 0, vinte = 0, dez = 0, cinco = 0, dois = 0, um = 0;
            //int menorVl = entrada;
            //while (menorVl > 0)
            //{
            //    if (menorVl >= 100) { menorVl -= 100; cem++; }
            //    else if (menorVl >= 50) { menorVl -= 50; cinquenta++; }
            //    else if (menorVl >= 20) { menorVl -= 20; vinte++; }
            //    else if (menorVl >= 10) { menorVl -= 10; dez++; }
            //    else if (menorVl >= 5) { menorVl -= 5; cinco++; }
            //    else if (menorVl >= 2) { menorVl -= 2; dois++; }
            //    else if (menorVl.Equals(1)) { menorVl -= 1; um++; }
            //    continue;
            //}

            //Console.WriteLine("Deve Retornar:");
            //Console.WriteLine($" {cem} células de r$100,00");
            //Console.WriteLine($" {cinquenta} células de r$50,00");
            //Console.WriteLine($" {vinte} células de r$20,00");
            //Console.WriteLine($" {dez} células de r$10,00");
            //Console.WriteLine($" {cinco} células de r$5,00");
            //Console.WriteLine($" {dois} células de r$2,00");
            //Console.WriteLine($" {um} células de r$1,00");
            //Console.WriteLine($"Total:{entrada}");
            #endregion
        }
    }
}
