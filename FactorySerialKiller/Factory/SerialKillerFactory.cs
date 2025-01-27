using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Models
{
    public class SerialKillerFactory
    {
        private static string? message = "Le nom du sérial killer n'est pas encore connu !!!";

        public static ISerialKiller CreateKiller(string killerType)
        {
            if (string.IsNullOrWhiteSpace(killerType))
            {
                throw new ArgumentException("Le nom du sérial killer ne peut pas être vide ou nul.");
            }

            return killerType.ToLower() switch
            {
                "bundy" => new Bundy(),
                "jack" => new Jack(),
                "dahmer" => new Dahmer(),
                "garavito" => new Garavito(),
                _ => throw new ArgumentException($"Le nom du sérial killer '{killerType}' n'est pas valide ou pas pris en charge."),
            };
        }
    }
}
