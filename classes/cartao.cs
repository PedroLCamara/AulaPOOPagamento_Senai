using System;

namespace AulaPOOPagamento.classes
{
    public abstract class cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public string salvarCartao(){
            Console.WriteLine("Insira os dados do cartão");
            Console.WriteLine("Bandeira:");
            bandeira= Console.ReadLine();
            Console.WriteLine("Número:");
            numero= Console.ReadLine();
            Console.WriteLine("Titular:");
            titular= Console.ReadLine();
            Console.WriteLine("Cvv:");
            cvv= Console.ReadLine();
            return $"Cartão com o número {numero} registrado e pronto para efetuar o pagamento";
        }
    }
}