int vidaHeroi = 10;
int vidaMonstro = 10;

while(vidaHeroi > 0 && vidaMonstro > 0)
{
    int ataque = new Random().Next(1, 11);

    vidaMonstro -= ataque;
    Console.WriteLine($"O herói ataca com {ataque} de dano. Vida do monstro: {vidaMonstro}");
    
    if(vidaMonstro <= 0)
    {
        Console.WriteLine("O herói venceu!");
        break;
    }
    
    ataque= new Random().Next(1, 11);

    vidaHeroi -= ataque;  
    Console.WriteLine($"O monstro ataca com {ataque} de dano. Vida do herói: {vidaHeroi}");
      
    if(vidaHeroi <= 0)
    {
        Console.WriteLine("O monstro venceu!");
        break;
    }   
}