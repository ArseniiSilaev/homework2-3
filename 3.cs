using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
internal class Program
{
static void Main(string[] args)
{
Console.Write("Введите кол-во золота: ");
float gold = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите кол-во эликсира: ");
float elixir = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите кол-во кристаллов: ");
float gems = Convert.ToSingle(Console.ReadLine());
float goldToElixir = 0.5f;
float goldToGems = 0.1f;
float elixirToGold = 1.9f;
float elixirToGems = 0.2f;
float gemsToGold = 8.0f;
float gemsToElixir = 4.0f;
while (true)
{
Console.WriteLine("Нажмите 1, если хотите обменять золото на эликсир.");
Console.WriteLine("Нажмите 2, если хотите обменять золото на кристаллы.");
Console.WriteLine("Нажмите 3, если хотите обменять эликсир на золото.");
Console.WriteLine("Нажмите 4, если хотите обменять эликсир на кристаллы.");
Console.WriteLine("Нажмите 5, если хотите обменять кристаллы на золото.");
Console.WriteLine("Нажмите 6, если хотите обменять кристаллы на эликсир.");
Console.WriteLine("Нажмите 7, если хотите закончить.");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
float variable;
if (number == 1)
{
Console.Write("Сколько золота будете обменивать?: ");
variable = Convert.ToSingle(Console.ReadLine());
if (variable <= gold)
{
Console.WriteLine("У вас " + (gold - variable) + " золота, " + (elixir + variable * goldToElixir) + " эликсира и " + gems + " кристаллов");
gold -= variable;
elixir += variable * goldToElixir;
}
else
{
Console.WriteLine("Ошибка");
}
}
if (number == 2)
{
Console.Write("Сколько золота будете обменивать?: ");
variable = Convert.ToSingle(Console.ReadLine());
if (variable <= gold)
{
Console.WriteLine("У вас " + (gold - variable) + " золота, " + elixir + " эликсира и " + (gems + variable * goldToGems) + " кристаллов");
gold -= variable;
gems += variable * goldToGems;
}
else
{
Console.WriteLine("Ошибка");
}
}
if (number == 3)
{
Console.Write("Сколько эликсира будете обменивать?: ");
variable = Convert.ToSingle(Console.ReadLine());
if (variable <= elixir)
{
Console.WriteLine("У вас " + (gold + variable * elixirToGold) + " золота, " + (elixir - variable) + " эликсира и " + gems + " кристаллов");
gold += variable * elixirToGold;
elixir -= variable;
}
else
{
Console.WriteLine("Ошибка");
}
}
if (number == 4)
{
Console.Write("Сколько эликсира будете обменивать?: ");
variable = Convert.ToSingle(Console.ReadLine());
if (variable <= elixir)
{
Console.WriteLine("У вас " + gold + " золота, " + (elixir - variable) + " эликсира и " + (gems + variable * elixirToGems) + " кристаллов");
elixir -= variable;
gems += variable * elixirToGems;
}
else
{
Console.WriteLine("Ошибка");
}
}
if (number == 5)
{
Console.Write("Сколько кристаллов будете обменивать?: ");
variable = Convert.ToSingle(Console.ReadLine());
if (variable <= gems)
{
Console.WriteLine("У вас " + (gold + variable * gemsToGold) + " золота, " + elixir + " эликсира и " + (gems - variable) + " кристаллов");
gold += variable * gemsToGold;
gems -= variable;
}
else
{
Console.WriteLine("Ошибка");
}
}
if (number == 6)
{
Console.Write("Сколько кристаллов будете обменивать?: ");
variable = Convert.ToSingle(Console.ReadLine());
if (variable <= gems)
{
Console.WriteLine("У вас " + gold + " золота, " + (elixir + variable * gemsToElixir) + " эликсира и " + (gems - variable) + " кристаллов");
elixir += variable * gemsToElixir;
gems -= variable;
}
else
{
Console.WriteLine("Ошибка");
}
}
if (number == 7)
{
Console.WriteLine("У вас " + gold + " золота, " + elixir + " эликсира и " + gems + " кристаллов");
break;
}
}

}
}
}
