using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Models
{
    public class Bundy : ISerialKiller
    {
        int activity = 8;
        int production = 30;
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
            return "Ted Bundy";
        }

        public int GetProduction()
        {
            return production;
        }

        public string GetSurname()
        {
            return "Le BG!";
        }

        public string GetVictimGenre()
        {
            return "jeunes femmes";
        }
    }
}
