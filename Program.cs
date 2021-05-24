using System;
using AulaPOOPagamento.classes;

namespace AulaPOOPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            bool respostaValida = false;
            Console.WriteLine(@"Digite o método de pagamento desejado
            1- Boleto
            2- Cartão de crédito
            3- Cartão de débito
            4- Cancelar");
            opcao = Console.ReadLine().Substring(0, 1);
            do
            {
                switch (opcao)
                {
                    case "1":
                        boleto b = new boleto();
                        b.registrar();
                        respostaValida=true;
                        break;
                    case "2":
                        credito c = new credito();
                        Console.WriteLine($"{c.salvarCartao()}");
                        c.pagar();
                        respostaValida=true;
                        break;
                    case "3":
                        debito d = new debito();
                        Console.WriteLine($"{d.salvarCartao()}");
                        d.pagar();
                        respostaValida=true;
                        break;
                    case "4":
                        Pagamento p = new Pagamento();
                        Console.WriteLine($"{p.cancelar()}");
                        respostaValida=true;
                        break;
                    default:
                        Console.WriteLine("Resposta inválida, digite '1' para pagar com boleto, '2' para pagar com o cartão de crédito, '3' com o de débito e '4' para cancelar a compra.");
                        respostaValida=false;
                        break;
                }
            } while (respostaValida == false);

        }
    }
}
