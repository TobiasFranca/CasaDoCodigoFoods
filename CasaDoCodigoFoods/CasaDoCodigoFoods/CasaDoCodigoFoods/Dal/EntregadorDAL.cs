using CasaDoCodigoFoods.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigoFoods.Dal
{
    public class EntregadorDAL
    {
        private ObservableCollection<Entregador> Entregadores = new ObservableCollection<Entregador>();
        private static EntregadorDAL EntregadorInstance = new EntregadorDAL();

        private EntregadorDAL()
        {
            Entregadores.Add(new Entregador() { Id = 1, Nome = "Brauzio", Telefone = "Asdrugio" });
            Entregadores.Add(new Entregador() { Id = 2, Nome = "Entencius", Telefone = "Gesfredio" });
            Entregadores.Add(new Entregador() { Id = 3, Nome = "Cartucious", Telefone = "Asdrugio" });
            Entregadores.Add(new Entregador() { Id = 4, Nome = "Adoliterio", Telefone = "Gesifrelio" });
            Entregadores.Add(new Entregador() { Id = 5, Nome = "Castrogildo", Telefone = "Kentencio" });
            Entregadores.Add(new Entregador() { Id = 6, Nome = "Asdrugio", Telefone = "Adoliterio" });
            Entregadores.Add(new Entregador() { Id = 7, Nome = "Gesfrundio", Telefone = "Cartucious" });
            Entregadores.Add(new Entregador() { Id = 8, Nome = "Kentencio", Telefone = "Entencius" });
            Entregadores.Add(new Entregador() { Id = 9, Nome = "Gesfredio", Telefone = "Brauzio" });
            Entregadores.Add(new Entregador() { Id = 10, Nome = "Gesifrelio", Telefone = "Gesfrundio" });
        }
    }
}
