using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contado.Domain
{
    public class Contato
    {
        /*
          Criar um programa de agenda de contatos. O programa deve ter uma listagem onde é possível buscar o contato pelo nome.
          O contato deve ter nome, endereço completo, telefone, celular e e-mail. Deve ter também uma opção para cadastrar novo 
          contato. Ao clicar duas vezes sobre um contato na lista, abre a opção de detalhes do contato, podendo ser editado os
          dados do mesmo. Deve permitir também excluir contato da lista. Definir um formato de arquivo e criar uma importação de 
          contatos a partir de um arquivo texto (delimitado por tamanho de campo, por vírgula, fica aberto para escolher).     
         */

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string  Email { get; set; }


    }
}
