using System;

namespace AulaPOOPagamento.classes
{
    public class debito : cartao
    {
        private float saldo= 600;

        public void pagar(){
            if (saldo>= this.valor)
            {
                Console.WriteLine($"O produto foi pago com sucesso! O valor foi de {valor:C2}");
            }
            else
            {
                Console.WriteLine("O saldo do cartão não cobre o valor!");
            }
        }
    }
}