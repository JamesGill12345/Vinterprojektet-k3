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

if (Pengar == 0)
{
 isdone = true;
}


System.Console.WriteLine("Välkommen till spelet");



while (isdone == false)
{

    


    System.Console.WriteLine("Välj en ingrediens att lägga till");
    System.Console.WriteLine("skriv ett nummer från 0-4 för att lägga till en ingrediens");
    string ingr = System.Console.ReadLine();
    int tal;
    
    tal = int.Parse(ingr);

    System.Console.WriteLine($"{Ingredienser[tal].name} har lagts till du har {Pengar} Pengar kvar, testa att lägga till en till");
}