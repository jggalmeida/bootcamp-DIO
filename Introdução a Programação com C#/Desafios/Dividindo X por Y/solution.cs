using System;

class Desafio {
    static void Main() {
        //TODO: implementar if para verificar se o valor de entrada informado pelo usuário é menor que 0 e solicitar novo valor
        //TODO: implementar if para verificar se o valor de entrada informado pelo usuário é igual a zero e encerrar o programa
        //informa a quantidade de repetições de entradas que irão acontecer
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                //divide o valor de x por y
                double divisao = X / Y;
                if(divisao < 0 && (divisao.ToString("N1") == "0.0"))
                  Console.WriteLine("-0.0");
                else
                  Console.WriteLine(divisao.ToString("N1"));
            }
        }
    }
}