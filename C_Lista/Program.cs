using System;

namespace C_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaContatos agenda = new ListaContatos();
            int opc;

            do
            {
                opc = Menu();
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        agenda.Inserir(Ler_Contato());
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Deletar_Contato(agenda);
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        agenda.Imprimir();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine($"A quantidade de contatos é {agenda.QuantidadeContatos}");
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("SOFTWARE FINALIZADO!!!!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.Beep();
                        Console.WriteLine("------ OPÇÃO INVÁLIDA TENTE NOVAMENTE!!! ------\n\n\n\n");
                        Console.ReadLine();
                        break;
                }
            } while (opc != 0);
        }

        public static int Menu()
        {
            int opc;
            Console.WriteLine("----------------------- MENU PRINCIPAL -----------------------");
            Console.WriteLine("----------------------- 1 - Inserir Contato   ----------------");
            Console.WriteLine("----------------------- 2 - Localizar Contato ----------------");
            Console.WriteLine("----------------------- 3 - Remover Contato   ----------------");
            Console.WriteLine("----------------------- 4 - Editar Contato    ----------------");
            Console.WriteLine("----------------------- 5 - Imprimir contatos ----------------");
            Console.WriteLine("----------------------- 6 - Quantidade de contatos -----------");
            Console.WriteLine("----------------------- 0 - Sair              ----------------");
            Console.WriteLine("--------------------------------------------------------------");
            opc = int.Parse(Console.ReadLine());
            return opc;
        }

        public static Contato Ler_Contato()
        {
            string nome, email, tipo, opcao;
            int ddd, numero;
            bool esc, escolhaTipo;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu E-mail");
            email = Console.ReadLine();
            Console.WriteLine("Qual o tipo de contato? (1 - Pessoal / 2 - Comercial)");
            tipo = Console.ReadLine().ToLower();

            do
            {
                if (tipo == "1" || tipo == "pessoal")
                {
                    tipo = "Pessoal";
                    escolhaTipo = true;
                }
                else if (tipo == "2" || tipo == "comercial")
                {
                    tipo = "Comercial";
                    escolhaTipo = true;
                }
                else
                {
                    Console.Clear();
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, tente novamente!\n");
                    Console.ResetColor();
                    Console.WriteLine("Qual o tipo de contato? (1 - Pessoal / 2 - Comercial)");
                    tipo = Console.ReadLine().ToLower();
                    Console.Clear();
                    escolhaTipo = false;
                }
            } while (escolhaTipo != true);

            Console.WriteLine("Digite o DDD");
            ddd = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Número");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja cadastras mais algum número Telefonico? (Sim/Não)");
            opcao = Console.ReadLine().ToLower();

            do
            {
                if (opcao == "sim")
                {
                    Console.WriteLine("Qual o tipo de contato? (1 - Pessoal / 2 - Comercial)");
                    tipo = Console.ReadLine().ToLower();
                    do
                    {
                        if (tipo == "1" || tipo == "pessoal")
                        {
                            tipo = "Pessoal";
                            escolhaTipo = true;
                        }
                        else if (tipo == "2" || tipo == "comercial")
                        {
                            tipo = "Comercial";
                            escolhaTipo = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.Beep();
                            Console.WriteLine("Opção inválida, tente novamente!\n");
                            Console.WriteLine("Qual o tipo de contato? (1 - Pessoal / 2 - Comercial)");
                            tipo = Console.ReadLine().ToLower();
                            Console.Clear();
                            escolhaTipo = false;
                        }
                    } while (escolhaTipo != true);

                    Console.WriteLine("Digite o DDD");
                    ddd = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Número");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Deseja cadastras mais algum número Telefonico? (Sim/Não)");
                    opcao = Console.ReadLine().ToLower();
                    esc = true;
                }

                else if (opcao == "nao" || opcao == "não")
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t------CONTATO CADASTRADO ------");
                    Console.WriteLine("\tTecle algum botão para continuar!");
                    Console.ReadLine();
                    Console.Clear();
                    esc = true;
                }
                else
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("Opção inválida, tente novamente!\n");
                    Console.WriteLine("Deseja cadastras mais algum número Telefonico? (Sim/Não)");
                    opcao = Console.ReadLine().ToLower();
                    esc = false;
                }
            } while (esc != true);

            return new Contato(nome, email, Telefone);
        }
        
        public static void Deletar_Contato(ListaContatos agenda)
        {
            string nome;
            Console.WriteLine("Qual o nome do contato que deseja deletar?");
            nome = Console.ReadLine();
            agenda.Excluir(nome);
        }
    }
}
