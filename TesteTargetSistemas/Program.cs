using System.Globalization;
using System.Text.Json;

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

            Console.ReadKey();
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
            string caminhoArquivo = "dados.json";
            string conteudoJson = File.ReadAllText(caminhoArquivo);
            var dados = JsonSerializer.Deserialize<List<FaturamentoDiario>>(conteudoJson);

            var dadosOrdenados = dados.OrderBy(d => (double)d.valor).ToList();
            
            double menorValor;
            double maiorValor;
            double mediaFaturamento;
            int numeroDiasFaturamentoAcimaMedia = 0;

            // Encontra a posicao do menor valor e realiza o somatorio de todos os faturamentos
            int posicaoMenorValor = 0;
            double faturamentoTotal = 0;
            for (int i = 0; i < dadosOrdenados.Count; i++)
            {
                if (dadosOrdenados[i].valor == 0)
                {
                    posicaoMenorValor++;
                }

                faturamentoTotal += dadosOrdenados[i].valor;
            }

            menorValor = dadosOrdenados[posicaoMenorValor].valor;
            maiorValor = dadosOrdenados[dadosOrdenados.Count - 1].valor;
            mediaFaturamento = faturamentoTotal / (dadosOrdenados.Count - posicaoMenorValor + 1);

            for (int i = 0; i < dadosOrdenados.Count; i++)
            {
                if (dadosOrdenados[i].valor > mediaFaturamento)
                {
                    numeroDiasFaturamentoAcimaMedia = dadosOrdenados.Count - i;
                    break;
                }
            }

            System.Console.WriteLine(string.Format("Menor valor de faturamento: R$ {0}.", string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", menorValor)));
            System.Console.WriteLine(string.Format("Maior valor de faturamento: R$ {0}.", string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", maiorValor)));
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

            System.Console.WriteLine("SP: " + Math.Round((SP * 100) / Total, 2) + "%");
            System.Console.WriteLine("RJ: " + Math.Round((RJ * 100) / Total, 2) + "%");
            System.Console.WriteLine("MG: " + Math.Round((MG * 100) / Total, 2) + "%");
            System.Console.WriteLine("ES: " + Math.Round((ES * 100) / Total, 2) + "%");
            System.Console.WriteLine("Outros: " + Math.Round((Outros * 100) / Total, 2) + "%");
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

    public class FaturamentoDiario
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }
}