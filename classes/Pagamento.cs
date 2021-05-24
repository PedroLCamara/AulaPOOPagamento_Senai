using System;

namespace AulaPOOPagamento.classes
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now.Date;
        protected float valor= 2000;

        public string cancelar(){
            return $"Pagamento cancelado.";
        }
    }
}