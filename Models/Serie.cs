using System;
using CadastroDeSeries.Enums;

namespace CadastroDeSeries.Models
{
    public class Serie : EntidadeBase
    {
        public Serie(Genero genero, string titulo, string descricao, int ano, int id)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;

        }
        private Genero Genero { get; set; }

        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero +Environment.NewLine;
            retorno += "Titulo: " + this.Titulo +Environment.NewLine;
            retorno += "Descrição: " + this.Descricao +Environment.NewLine;
            retorno += "Excluido: " + this.Excluido +Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        
    }
}