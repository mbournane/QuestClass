namespace Classes;

public class Program
{
    static void Main(string[] args)
    {
        Character attaquant = new Character();
        Character attaquee = new Character();
        Console.Write("entrez le nom du premier joueur :" );
        attaquant.nameChar = Console.ReadLine();
        Console.Write("entrez le nom du deuxieme joueur :" );
        attaquee.nameChar = Console.ReadLine();
        attaquant.lifePoints = 50;
        attaquant.attackStrength = 5;
        attaquant.defenseStrength = 2 ;

        attaquee.lifePoints = 45;
        attaquee.attackStrength = 3;
        attaquee.defenseStrength = 1 ;

        while(attaquant.IsAlive() && attaquee.IsAlive())
        {
            attaquant.Attack(attaquee);
        }
        if(attaquant.IsAlive())
        
            Console.WriteLine("le joueur " + attaquant.nameChar + " a gagnée" );
        else 
            Console.WriteLine("le joueur " + attaquee.nameChar + " a gagnée" );
    }
}
