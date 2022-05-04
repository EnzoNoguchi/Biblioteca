using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlCliente
    {
        Cliente cliente; //Conectando a model e a control
        private int opcao;

        public ControlCliente()
        {
            cliente = new Cliente();
        }//fim do construtor


        public int AcessarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }//fim da opcao
          



        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "1. Cadastrar \n" +
                              "2. Consultar \n" +
                              "3. Atualizar Nome\n" +
                              "4. Atualizar Telefone\n" +
                              "5. Atualizar Endereço\n" +
                              "6. Excluir \n"   +
                              "7. Sair");
            AcessarOpcao = Convert.ToInt32(Console.ReadLine());

        }//fim do metodo menu

        public void Executar()
        {
            do
            {
                Menu();
                    //executar a ação
                    switch (AcessarOpcao)
                    {
                        case 0:
                            Console.WriteLine("Obrigado!");
                            break;


                        case 1:
                            Console.WriteLine("Informe um codigo: ");
                            int codigo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Informe um nome: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Informe um telefone: ");
                            string telefone = Console.ReadLine();
                            Console.WriteLine("informe um endereço: ");
                            string endereco = Console.ReadLine();
                            //Passei o dado por parametro para o metodo
                            cliente.Cadastrar(codigo, nome, telefone, endereco);
                            //Mostro o dado em tela
                            Console.WriteLine("Cadastro com Sucesso!");
                            break;




                        case 2:
                            //Pedir para o usuario digitar um codigo
                            Console.WriteLine("Informe um codigo: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                            //mostrar o resultado da operação
                            Console.WriteLine(cliente.Consultar(codigo));
                            break;




                        case 3:
                            //Pedir para o usuario digitar o codigo e o novo nome
                            Console.WriteLine("Informe um codigo: ");
                            codigo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe um nome: ");
                            nome = Console.ReadLine();
                            //Utilizar o metodo da classe model
                            Console.WriteLine(cliente.AtualizarNomes(codigo, nome));
                            break;




                        case 4:
                            //Pedir para o usuario digitar o codigo e o novo nome
                            Console.WriteLine("Informe um codigo: ");
                            codigo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe um telefone: ");
                            telefone = Console.ReadLine();
                            //Utilizar o metodo da classe model
                            Console.WriteLine(cliente.AtualizarTelefone(codigo, telefone));
                            break;




                        case 5:
                            //Pedir para o usuario digitar o codigo e o novo nome
                            Console.WriteLine("Informe um codigo: ");
                            codigo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe um endereço: ");
                            endereco = Console.ReadLine();
                            //Utilizar o metodo da classe model
                            Console.WriteLine(cliente.AtualizarNomes(codigo, endereco));
                            break;




                        case 6:
                            //Pedir para o usuario digitar o codigo e o novo nome
                            Console.WriteLine("Informe um codigo: ");
                            codigo = Convert.ToInt32(Console.ReadLine());
                            //Utiliza o metodo
                            Console.WriteLine(cliente.Excluir(codigo));
                            break;
                        default:
                            Console.WriteLine("Codigo digitado não é valido!");
                            break;
            
            
                     }//fim do switch
            }while (AcessarOpcao != 0); 



        }//fim do executar
    }//fim da control
}//fim do projeto
