using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq
{
    internal class GroupeService
    {
        public List<Groupe> getList()
        {
            var list = new List<Groupe>()
            {
                new Groupe() { id = 1, nom = "LICDA"},
                new Groupe() { id = 2, nom = "MIAGE" },
                new Groupe() { id = 3, nom = "Big Data"},
                new Groupe() { id = 4, nom = "ISRI"}
            };
            return list;
        }

    }
}
