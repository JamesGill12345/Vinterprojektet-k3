List<Ingredient> Ingredienser = new List<Ingredient>();
Ingredienser.Add(new Ingredient()); // 0
Ingredienser.Add(new Ingredient()); // 1
Ingredienser.Add(new Ingredient()); // 2
Ingredienser.Add(new Ingredient()); // 3
Ingredienser.Add(new Ingredient()); // 4

int length = Ingredienser.Count;


int Pengar = 250;

bool isdone = false;

Ingredienser[0].name = "Sallad";
Ingredienser[1].name = "Kött";
Ingredienser[2].name = "Bröd";
Ingredienser[3].name = "Korv";
Ingredienser[4].name = "Krydda";

Ingredienser[0].Cost = 25;
Ingredienser[1].Cost = 30;
Ingredienser[2].Cost = 15;
Ingredienser[3].Cost = 40;
Ingredienser[4].Cost = 60;

Ingredienser[0].Sweetness = 2;
Ingredienser[1].Sweetness = 3;
Ingredienser[2].Sweetness = 6;
Ingredienser[3].Sweetness = 4;
Ingredienser[4].Sweetness = 8;

Ingredienser[0].Sourness = 8;
Ingredienser[1].Sourness = 3;
Ingredienser[2].Sourness = 1;
Ingredienser[3].Sourness = 2;
Ingredienser[4].Sourness = 7;

Ingredienser[0].Healthyness = 8;
Ingredienser[1].Healthyness = 4;
Ingredienser[2].Healthyness = 3;
Ingredienser[3].Healthyness = 3;
Ingredienser[4].Healthyness = 7;

List<Judge> Dommare = new List<Judge>();
Dommare.Add(new Judge()); // 0
Dommare.Add(new Judge()); // 1
Dommare.Add(new Judge()); // 2

Dommare[0].LikesHealthyness = 0;
Dommare[0].LikesSourness = 3;
Dommare[0].LikesSweetness = 10;

Dommare[1].LikesHealthyness = 8;
Dommare[1].LikesSourness = 5;
Dommare[1].LikesSweetness = 1;

Dommare[2].LikesHealthyness = 2;
Dommare[2].LikesSourness = 10;
Dommare[2].LikesSweetness = 7;


System.Console.WriteLine("Välkommen till spelet");



while (isdone == false)
{
    if (Pengar <= 0)
{
    Pengar = 0;
    isdone = true;
}


    


    System.Console.WriteLine("Välj en ingrediens att lägga till");
    System.Console.WriteLine("skriv ett nummer från 0-4 för att lägga till en ingrediens");
    string ingr = System.Console.ReadLine();
    int tal;
    
    tal = int.Parse(ingr);
    Pengar = Pengar -Ingredienser[tal].Cost;
    System.Console.WriteLine($"{Ingredienser[tal].name} har lagts till du har {Pengar} Pengar kvar, testa att lägga till en till");
    System.Console.WriteLine($"{Ingredienser[tal].name} hade {Ingredienser[tal].Sweetness} i söthet och {Ingredienser[tal].Sourness} i surhet och {Ingredienser[tal].Healthyness} i hälsosammhet");

    int matstats = Ingredienser[tal].Sweetness + Ingredienser[tal].Sourness + Ingredienser[tal].Healthyness;
    System.Console.WriteLine($"{matstats} är dina ingrediensers sammanlagda värde.");


    foreach (Judge judge in Dommare)
    {
        
    }

}
if(isdone == true)
{
    System.Console.WriteLine("Din maträtt är klar");


    
}