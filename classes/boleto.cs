using System;

namespace AulaPOOPagamento.classes
{
    public class boleto: Pagamento
    {
        private string codigoDeBarras;
        public void registrar(){
            Random rd = new Random();
            codigoDeBarras = rd.Next(3000000).ToString();
            Console.WriteLine($"O boleto foi gerado! Código: {codigoDeBarras}. Seu valor é de {(this.valor* 0.88):C2} com o desconto de 12% já aplicado.");
        }
    }
}