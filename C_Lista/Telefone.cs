using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica
{
    public class Phone
    {
        public string Numero { get; set; }
        public int DDD { get; set; }
        public string Tipo { get; set; }
        public Phone Proximo { get; set; }

        public Phone(string numero, int dDD, string tipo)
        {
            Numero = numero;
            DDD = dDD;
            Tipo = tipo;
            Proximo = null;
        }

        public override string ToString()
        {
            return $"{Tipo} => ({DDD}) {Numero}";
        }
    }
}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lista
{
    internal class Telefone
    {
        public string Tipo { get; set; }
        public int Ddd { get; set; }
        public int Numero { get; set; }
        public Telefone Head { get; set; }
        public Telefone Tail { get; set; }
        public Telefone Proximo { get; set; }
        public Telefone telefone { get; set; }

        public Telefone(string tipo, int ddd, int numero)
        {
            Tipo = tipo;
            Ddd = ddd;
            Numero = numero;
            Head = Tail = telefone = null;
        }

        public void Inserir_Numero(Telefone aux)
        {
            if (Vazio())
            {
                Head = Tail = aux;
            }
            else
            {
                Proximo = aux;
                Head = aux;
                Tail = aux;
            }
            
        }
        public bool Vazio()
        {
            if (Head == null && Tail == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"\n|Tipo: {Tipo} - ({Ddd}) {Numero}";
        }
    }
}
*/