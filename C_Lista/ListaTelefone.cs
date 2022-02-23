using System;

namespace ListaTelefonica
{
    public class PhoneList
    {
        public Phone Head { get; set; }
        public Phone Tail { get; set; }
        public int Count { get; set; }

        public PhoneList()
        {
            Head = Tail = null;
        }

        public void Insert(Phone aux)
        {
            if (IsEmpty())
            {
                Head = Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;
                Tail = aux;
            }
        }

        bool IsEmpty()
        {
            return Head == null && Tail == null;
        }

        public override string ToString()
        {
            string text = "[";
            if (IsEmpty())
            {
                Console.WriteLine("[Lista de Telefones esta vazia!]");
            }
            else
            {
                Phone aux = Head;
                do
                {
                    if (aux.Proximo == null)
                    {
                        text += $"{aux}";
                    }
                    else
                    {
                        text += $"{aux} // ";
                    }
                    aux = aux.Proximo;
                    Console.ReadKey();
                } while (aux != null);
            }
            text += "]";
            return text;
        }

    }
}