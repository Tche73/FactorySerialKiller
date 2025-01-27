using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Interface
{
    public interface ISerialKiller
    {
        string GetName();
        string GetSurname(); 
        int GetProduction();
        int GetAnnualActivty();
        int GetAnnualRate();
        string GetVictimGenre();
    }
}
