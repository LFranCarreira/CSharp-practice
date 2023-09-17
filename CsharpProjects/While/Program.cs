// Random dice = new Random();
// int heroeHealth = 10;
// int villianHealth = 10;
// do
// {
//     int roll = dice.Next(1,11);
//     villianHealth-=roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {villianHealth} health.");
    
//     if(villianHealth <= 0)continue;

//     roll = dice.Next(1,11);
//     heroeHealth -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroeHealth} health.");
// } while (heroeHealth > 0 && villianHealth > 0);
// Console.WriteLine(heroeHealth > villianHealth ? "Hero Wins!" : "Monster Wins!");
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);