using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Models
{
    public class Dahmer : ISerialKiller
    {
        int activity = 13;
        int production = 17;
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
            return "Jeffrey Dahmer";
        }

        public int GetProduction()
        {
            return production;
        }

        public string GetSurname()
        {
            return "La cannibale de Milwaukee !";
        }

        public string GetVictimGenre()
        {
            return "Homosexuels";
        }
    }
}
