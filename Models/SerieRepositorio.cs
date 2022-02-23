using CadastroDeSeries.Interfaces;
using System.Collections.Generic;
using CadastroDeSeries.Models;

namespace CadastroDeSeries.Models
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        public List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
           listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
        

    }
}