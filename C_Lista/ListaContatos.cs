using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lista
{
    internal class ListaContatos
    {
        public Contato Head { get; set; }
        public Contato Tail { get; set; }
        public int QuantidadeContatos { get; set; }

        public ListaContatos()
        {
            Head = Tail = null;
        }

        public void Inserir(Contato aux)
        {
            if (Vazio())
            {
                Head = Tail = aux;
            }
            else
            {
                Contato aux1, aux2;
                aux1 = aux2 = Head;

                do
                {
                    if (Head == Tail)
                    {
                        if (aux.Nome.CompareTo(Tail.Nome) == 1)
                        {
                            Tail.Proximo = aux;
                            Tail = aux;
                            break;
                        }
                        else
                        {
                            aux.Proximo = Head;
                            Head = aux;
                            break;
                        }
                    }
                    else
                    {
                        if (aux.Nome.CompareTo(aux1.Nome) == -1)
                        {
                            aux.Proximo = Head;
                            Head = aux;
                            break;
                        }
                        else if (aux.Nome.CompareTo(aux1.Nome) == 1 || aux.Nome.CompareTo(aux1.Nome) == 0)
                        {
                            aux1 = aux1.Proximo;
                            if (aux1 == null)
                            {
                                Tail.Proximo = aux;
                                Tail = aux;
                                break;
                            }
                            else if (aux.Nome.CompareTo(aux1.Nome) == -1)
                            {
                                aux2.Proximo = aux;
                                aux.Proximo = aux1;
                                break;
                            }
                        }
                    }
                    aux2 = aux1;
                } while (aux1 != null);
            }
            QuantidadeContatos++;
        }

        public void Imprimir()
        {
            if (Vazio())
            {
                Console.WriteLine("---- LISTA VAZIA ----");
            }
            else
            {
                Contato aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                    Console.ReadLine();
                } while (aux != null);
            }
        }

        public void Excluir(string nome)
        {
            if (Vazio())
            {
                Console.Clear();
                Console.WriteLine("---- LISTA VAZIA ----\n\n\n\n");
            }
            else
            {
                Contato aux1, aux2;
                aux1 = aux2 = Head;
                do
                {
                    if (nome == aux1.Nome)
                    {
                        if (Head == Tail)
                        {
                            if (nome == Head.Nome && nome == Tail.Nome)
                            {
                                Head = Tail = null;
                            }
                        }
                        else if (aux1.Nome == Head.Nome)
                        {
                            Head.Proximo = aux1.Proximo;
                            aux1.Proximo = null;
                        }
                        else if (aux1.Nome == Tail.Nome)
                        {
                            aux2.Proximo = null;
                            Tail.Proximo = aux2.Proximo;
                        }
                        else if (aux1.Nome != aux2.Nome)
                        {
                            aux1.Proximo = aux1.Proximo;

                        }
                        else
                        {
                            aux2.Proximo = aux1.Proximo;
                            aux1.Proximo = null;
                        }
                    }
                    if (aux1.Nome != aux2.Nome)
                    {
                        aux1 = aux1.Proximo;
                        aux2 = aux2.Proximo;
                    }
                    else 
                    {
                        aux1 = aux1.Proximo;
                    }
                } while (aux1 != null);
            }
            QuantidadeContatos--;
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
    }
}
