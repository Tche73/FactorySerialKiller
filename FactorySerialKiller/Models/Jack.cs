using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Models
{
    public class Jack : ISerialKiller
    {
        int activity = 3;
        int production = 5;
        public int GetAnnualActivty()
        {

            return activity;
        }

        public int GetAnnualRate()
        {
            return production / activity;
        }

        public string GetName()
        {
            return "Aaron Kosminski (supposé)";
        }

        public int GetProduction()
        {
            return production;
        }

        public string GetSurname()
        {
            return "Jack l'éventreur!";
        }

        public string GetVictimGenre()
        {
            return "Prostituées";
        }
    }
}
