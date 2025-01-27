using CarteDeCreditFactory.Interface;
using CarteDeCreditFactory.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        string killerType = "";
        Console.WriteLine("Veuillez choisir un nom de sérial killer");
        Console.WriteLine("Bundy, Jack, Dahmer, Garavito");
        killerType = Console.ReadLine();

        try
        {
            ISerialKiller killerDetails = SerialKillerFactory.CreateKiller(killerType);
            Console.WriteLine(" ---- Détails du sérial killer ----\n");
            Console.WriteLine($"Nom : {killerDetails.GetName()}");
            Console.WriteLine($"Surnom : {killerDetails.GetSurname()}");
            Console.WriteLine($"Genre des victimes : {killerDetails.GetVictimGenre()}");
            Console.WriteLine($"Nombre total de victimes : {killerDetails.GetProduction()}");
            Console.WriteLine($"Nombre d'années d'activité : {killerDetails.GetAnnualActivty()}");
            Console.WriteLine($"Taux annuel moyen : {killerDetails.GetAnnualRate()} victimes/an");
        }
        catch (ArgumentException ex)
        {
            // Message d'erreur clair pour l'utilisateur
            Console.WriteLine($"\nErreur : {ex.Message}");
        }
        catch (Exception ex)
        {
            // Pour toute autre erreur
            Console.WriteLine($"\nUne erreur inattendue s'est produite : {ex.Message}");
        }


    }

}