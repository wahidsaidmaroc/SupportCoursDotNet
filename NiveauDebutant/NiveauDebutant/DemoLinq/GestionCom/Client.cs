using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq.GestionCom
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public List<Commande> Commandes { get; set; }
    }


    public class Commande
    {

        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public decimal Total { get; set; }
        public Client Client { get; set; }

    }
}
