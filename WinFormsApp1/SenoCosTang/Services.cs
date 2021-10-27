using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SenoCosTang
{
    public class Services : Props
    {
        public  Services(string numero)
        {
            this.numero = numero;
        }


        public override void Executar()
        {

            Validation val = new Validation(this.numero);
            val.Executar();
            this.mensagem = val.mensagem;
            this.valor = val.valor;

            if (mensagem != "erro")
            {
                Calc cal = new Calc(this.valor);
                cal.Executar();

                this.seno = cal.seno;
                this.cons = cal.cons;
                this.tang = cal.tang;
            }

             
        }

    }
}
