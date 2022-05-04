using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Cliente
    {
        //Declarar as variaveis
        private int codigo;
        private string nomeCompleto;
        private string telefone;
        private string endereco;





        public Cliente()
        {
            //instanciando as variaveis 
            AcessarCodigo = 0;
            AcessarNome = "";
            AcessarTelefone = "";
            AcessarEndereco = "";
        }//fim do metodo construtor
         






        //Desenvolver os metodos gets e sets
        public int AcessarCodigo
        {
            get
            {
                return codigo;
            }
            set
            {
                this.codigo = value;
            }
        }//fim do metodo de acesso do codigo


        public string AcessarNome
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                this.nomeCompleto = value;
            }
        }//fim do metodo de acesso do nome



        public string AcessarTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }//fim do metodo de acesso do telefone



        public string AcessarEndereco
        {
            get
            {
                return endereco;
            }
            set
            {
                this.endereco = value;
            }
        }//fim do metodo de acesso do endereço




        public void Cadastrar(int codigo, string nome, string telefone, string endereco)
        {
            AcessarCodigo = codigo;
            AcessarNome = nome;
            AcessarTelefone = telefone;
            AcessarEndereco = endereco;
        }//fim do metodo cadastrar 



        public string Consultar(int codigo)
        {
        if (AcessarCodigo == codigo)
        {
                return "Codigo: " + AcessarCodigo +
                       "\nNome Completo: " + AcessarNome +
                       "\nTelefone: " + AcessarTelefone +
                       "\nEndereço: " + AcessarEndereco;
        }
        else
        {
            return "Codigo Informado Não é Valido!";
        }
        }//fim do metodo Consultar 


        public string AtualizarNomes(int codigo, string nome)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarNome = nome;
                return "Dado atualizado com Sucesso!";
            }
            else
            {
                return "Codigo Informado Não é Valido!";
            }
        }//fim do metodo atualizarNome




        public string AtualizarTelefone(int codigo, string telefone)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarTelefone = telefone;
                return "Dado Atualizado com Sucesso";
            }
            else
            {
                return "Codigo digitado não é valido!";
            }
        }//fim do metodo atualizarTelefone



        public string AtualizarEndereco(int codigo, string endereco)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarEndereco = endereco;
                return "Endereço Atualizado com Sucesso";
            }
            else
            {
                return "Codigo digitado não é valido!";
            }
        }//fim do metodo atualizar Endereco




        public string Excluir(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarCodigo = 0;
                AcessarNome = "";
                AcessarTelefone = "";
                AcessarEndereco = "";
                return "Dados excluidos com sucesso!";
            }
            else
            {
                return "Codigo informado não é valido";
            }
        }//fim do excluir


    }//fm do classe
}//fim do projeto
