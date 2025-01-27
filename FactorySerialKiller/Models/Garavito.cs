using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Models
{
    public class Garavito : ISerialKiller
    {
        int activity = 10;
        int production = 138;
        public int GetAnnualActivty()
        {
            
            return activity;
        }

        public int GetAnnualRate()
        {

           return production/activity;  
        }

        public string GetName()
        {
            return "Luis Garavito";
        }

        public int GetProduction()
        {
            return production;
        }

        public string GetSurname()
        {
            return "La bête !";
        }

        public string GetVictimGenre()
        {
            return "Enfants";
        }
    }
}
