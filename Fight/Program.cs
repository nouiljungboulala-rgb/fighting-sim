int playerHealt = 100;
int enemyHealth = 100;

Console.WriteLine("Start");
Console.WriteLine("Type Start to begin");
string start = Console.ReadLine();
if (start == "Start")
{
    while (playerHealt > 0 && enemyHealth > 0)
    {
        Console.WriteLine("Type hit to");
        string hit = Console.ReadLine();

        if (hit == "hit")
        {
            int damage = Random.Shared.Next(5, 10);
            enemyHealth = enemyHealth - damage;
            Console.WriteLine("You hit for" + damage + "! Enemy health" + enemyHealth);

            if (enemyHealth > 0)
            {
                damage = Random.Shared.Next(5, 10);
                playerHealt = playerHealt - damage;
                Console.WriteLine("Enemy hits you for " + damage + "! Your Health:" + playerHealt);
            
        }


}

}

}
if (enemyHealth <= 0)
{
    Console.WriteLine("You win");
}
else
{
    Console.WriteLine("You win");
}
Console.ReadLine();