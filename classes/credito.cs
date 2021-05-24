using System;

namespace AulaPOOPagamento.classes
{
    public class credito : cartao
    {
        private float limite = 3000f;
        private int parcelas;

        public void pagar()
        {
            bool respostaValida= false;
            if (limite >= this.valor)
            {
                do
                {
                    Console.WriteLine("O limite do seu cartão cobre o valor que deve ser pago, insira agora a quantidade de parcelas (1 à 12, com juros de 5% até 6 parcelas e 8% para valores superiores)");
                    parcelas = int.Parse(Console.ReadLine());
                    if (parcelas >= 1 && parcelas <= 6)
                    {
                        Console.WriteLine($"O valor de {this.valor * 1.05:C2}, com os juros já aplicados, deverá ser pago em {parcelas} parcelas de {((this.valor * 1.05) / parcelas):C2}");
                        respostaValida= true;
                    }
                    else if (parcelas >= 7 && parcelas <= 12)
                    {
                        Console.WriteLine($"O valor de {this.valor * 1.08:C2}, com os juros já aplicados, deverá ser pago em {parcelas} parcelas de {((this.valor * 1.08) / parcelas):C2}");
                        respostaValida= true;
                    }
                    else
                    {
                        Console.WriteLine("Valor de parcelas inválido, digite um número de 1 a 12 para definir uma quantia válida de parcelas.");
                        respostaValida= false;
                    }
                } while (respostaValida== false);
            }
            else
            {
                Console.WriteLine("Não deu certo");
            }
        }
    }
}