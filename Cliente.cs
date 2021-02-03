using System;
using System.Collections.Generic;

namespace SisBanco
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente(string nome, string cPF, DateTime dataDeNascimento)
        {
            Nome = nome;
            CPF = cPF;
            DataDeNascimento = dataDeNascimento;
        }

      

        public string Nome { get; set; }
      
        public string CPF { get; set; }

        public DateTime DataDeNascimento { get; set; }

        private readonly List<string> Notificacao = new List<string>();


        public List<string> EhValida()
        {
            if (!ValidaIdade(DataDeNascimento))
                Notificacao.Add("Menor de idade nao pode abrir uma conta");

            if (CPF == "")
                Notificacao.Add("CPF deve ser informado");

            return Notificacao;
        }
     
        private bool ValidaIdade(DateTime dtaNasc)
        {

            return (((DateTime.Now - DataDeNascimento).TotalDays / 360) >= 18) ? true : false;
        }
    }
}