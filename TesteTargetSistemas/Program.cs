namespace Testes
{
    class Programa
    {
        static void Main(string[] args)
        {
            ResultadosDosTestes();
        }

        private static void ResultadosDosTestes()
        {
            Console.WriteLine("Resultados dos testes:\n");

            System.Console.WriteLine("Teste 1: ");
            Teste1();
            System.Console.WriteLine("\n");

            System.Console.WriteLine("Teste 2: ");
            Teste2();
            System.Console.WriteLine("\n");

            System.Console.WriteLine("Teste 3: ");
            Teste3();
            System.Console.WriteLine("\n");

            System.Console.WriteLine("Teste 4: ");
            Teste4();
            System.Console.WriteLine("\n");

            System.Console.WriteLine("Teste 5: ");
            Teste5();
        }

        private static void Teste1 () 
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            ImprimirSoma(SOMA);
        }

        private static void ImprimirSoma(int SOMA)
        {
            System.Console.WriteLine(SOMA);

        }

        private static void Teste2()
        {
            int num = 34;
            int fib1 = 0;
            int fib2 = 1;
            int fibMaior = 0;

            while (fib2 < num)
            {
                fibMaior = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibMaior;
            }

            if (fibMaior == num)
            {
                System.Console.WriteLine("O número pertence a sequência.");
            }
            else
            {
                System.Console.WriteLine("O número não pertence a sequência.");
            }
        }

        private static void Teste3()
        {
            List<double> faturamentos = new List<double> { 2883.16, 599.32, 0.0, 0.0, 9651.62, 0.0, 3614.0, 0.0, 0.0, 0.0, 7527.83, 0.0, 3715.91, 602.82, 5778.71, 6145.2, 0.0, 0.0, 1877.35, 1418.4, 6569.36, 2649.97, 1759.17, 3680.2, 7086.53, 797.13, 0.0, 0.0, 5826.57, 0.0, 0.0, 0.0, 0.0, 8026.94, 0.0, 9182.05, 5555.35, 0.0, 9048.9, 4912.16, 8044.12, 4641.32, 57.23, 58.24, 9853.49, 4920.49, 9292.13, 9960.97, 2946.26, 8705.79, 0.0, 0.0, 1496.53, 8460.69, 0.0, 4563.97, 0.0, 2482.42, 4990.51, 3523.85, 7580.54, 0.0, 3714.5, 5726.93, 7650.83, 1364.73, 0.0, 4623.9, 4471.54, 7558.02, 3332.03, 0.0, 0.0, 0.0, 0.0, 0.0, 4581.24, 2997.27, 0.0, 7451.62, 9125.84, 0.0, 0.0, 2931.77, 1132.53, 2252.97, 2223.18, 9816.47, 8263.46, 4944.49, 1668.29, 5931.87, 0.0, 8448.46, 7390.23, 2763.93, 0.0, 0.0, 5647.2, 0.0, 137.17, 0.0, 8024.81, 5486.09, 9935.42, 8491.35, 1743.9, 4589.84, 0.0, 0.0, 5361.88, 1596.55, 3138.03, 493.6, 0.0, 1530.4, 0.0, 2142.59, 0.0, 4496.29, 0.0, 0.0, 8542.88, 6152.86, 3594.73, 1454.74, 7733.96, 8225.86, 5039.18, 0.0, 6115.48, 6414.57, 1858.3, 5722.95, 1231.81, 4437.7, 5673.01, 9660.92, 7201.09, 0.0, 1257.13, 0.0, 292.04, 907.52, 8723.38, 6283.57, 5095.86, 0.0, 4556.6, 6721.4, 3595.63, 0.0, 8701.19, 0.0, 0.0, 3693.04, 943.94, 0.0, 0.0, 0.0, 3555.86, 0.0, 3459.24, 2676.09, 2522.7, 3687.0, 9289.55, 6509.84, 8886.77, 9931.98, 4458.92, 9997.25, 0.0, 8950.09, 9502.27, 8324.82, 4209.59, 2127.69, 6213.23, 349.52, 4545.78, 9869.28, 759.02, 4219.67, 9505.46, 0.0, 0.0, 2188.28, 1584.0, 7207.98, 2139.94, 5053.72, 1512.01, 488.62, 0.0, 0.0, 7227.57, 2841.65, 0.0, 0.0, 0.0, 5662.79, 9799.95, 5156.04, 0.0, 0.0, 0.0, 0.0, 7008.54, 5276.41, 454.14, 0.0, 0.0, 0.0, 0.0, 0.0, 6059.85, 3503.68, 1549.91, 0.0, 3219.16, 4794.32, 0.0, 5969.74, 4924.85, 8886.91, 0.0, 9028.54, 0.0, 0.0, 0.0, 5154.45, 5501.34, 0.0, 7590.73, 4481.6, 3400.65, 896.44, 8532.52, 0.0, 7036.29, 0.0, 0.0, 0.0, 4274.09, 678.29, 0.0, 479.18, 5729.36, 0.0, 0.0, 4330.81, 7578.35, 1469.38, 9139.63, 9029.99, 0.0, 7757.99, 0.0, 9378.15, 2254.7, 6736.79, 0.0, 6696.54, 3422.94, 0.0, 7989.92, 2537.36, 0.0, 3129.93, 1041.72, 0.0, 5319.81, 657.75, 0.0, 5025.03, 3612.47, 1806.35, 5707.63, 2457.09, 8093.16, 0.0, 7710.95, 3438.61, 0.0, 8535.95, 1879.37, 7137.96, 4832.21, 207.35, 0.0, 5400.67, 7162.16, 6249.5, 2492.18, 2102.2, 426.28, 2948.54, 229.01, 7706.73, 127.86, 1931.37, 5075.94, 7307.62, 9112.32, 476.23, 3708.53, 7179.63, 0.0, 7354.39, 5118.66, 6822.49, 1556.24, 8101.31, 2502.44, 0.0, 0.0, 8131.13, 0.0, 2932.29, 0.0, 0.0, 0.0, 6619.68, 0.0, 0.0, 1167.26, 5737.12, 499.12, 2279.42, 0.0, 3783.29, 0.0, 2346.72, 0.0, 855.04, 901.76, 0.0, 0.0, 8116.74, 3720.1, 0.0, 0.0, 0.0, 6218.76, 759.44, 2242.58, 5662.51, 5547.52, 3542.15, 0.0, 7612.65, 0.0, 6058.41, 275.47, 1708.31, 6514.11, 1596.61, 4754.18, 0.0, 2839.3, 39.16, 92.21, 7469.21, 4495.88 };
            List<double> vetorOrdenado = new List<double>();
            double menorValor;
            double maiorValor;
            double mediaFaturamento;
            int numeroDiasFaturamentoAcimaMedia = 0;

            vetorOrdenado = faturamentos;
            vetorOrdenado.Sort();

            // Encontra a posicao do menor valor e realiza o somatorio de todos os faturamentos
            int posicaoMenorValor = 0;
            double faturamentoTotal = 0;
            for (int i = 0; i < vetorOrdenado.Count; i++)
            {
                if (vetorOrdenado[i] == 0)
                {
                    posicaoMenorValor++;
                }

                faturamentoTotal += vetorOrdenado[i];
            }

            menorValor = vetorOrdenado[posicaoMenorValor];
            maiorValor = vetorOrdenado[faturamentos.Count - 1];
            mediaFaturamento = faturamentoTotal / (faturamentos.Count - posicaoMenorValor + 1);

            for (int i = 0; i < vetorOrdenado.Count; i++)
            {
                if (vetorOrdenado[i] > mediaFaturamento)
                {
                    numeroDiasFaturamentoAcimaMedia = vetorOrdenado.Count - i + 1;
                    break;
                }
            }

            System.Console.WriteLine(string.Format("Menor valor de faturamento: R$ {0}.", menorValor.ToString().Replace('.', ',')));
            System.Console.WriteLine(string.Format("Maior valor de faturamento: R$ {0}.", maiorValor.ToString().Replace('.', ',')));
            System.Console.WriteLine(string.Format("Número de dias com faturamento acima da média: {0} dias.", numeroDiasFaturamentoAcimaMedia.ToString()));
        }

        private static void Teste4()
        {
            decimal SP = 67836.43M;
            decimal RJ = 36678.66M;
            decimal MG = 29229.88M;
            decimal ES = 27165.48M;
            decimal Outros = 19849.53M;

            decimal Total = SP + RJ + MG + ES + Outros;

            System.Console.WriteLine("SP: " + Math.Round((SP * 100) / Total, 2));
            System.Console.WriteLine("RJ: " + Math.Round((RJ * 100) / Total, 2));
            System.Console.WriteLine("MG: " + Math.Round((MG * 100) / Total, 2));
            System.Console.WriteLine("ES: " + Math.Round((ES * 100) / Total, 2));
            System.Console.WriteLine("Outros: " + Math.Round((Outros * 100) / Total, 2));
        }

        private static void Teste5()
        {
            string stringOriginal = "target";
            string stringInvertida = string.Empty;

            for (int indice = stringOriginal.Length - 1; indice > -1; indice --)
            {
                stringInvertida = stringInvertida + stringOriginal[indice];
            }

            System.Console.WriteLine("String original: " + stringOriginal);
            System.Console.WriteLine("String invertida: " + stringInvertida);
        }
    }
}