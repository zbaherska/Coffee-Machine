
/*
  Автомат гарячих напоїв. 
Створити ієрархію класів для подання гарячих напоїв Автомату(кава, чай, капучіно та ін.)
Створити програму для роботи Автомату у  режимах адмін та користувач
У режимі адміна передбачити 	
	Завантаження автомату водою, кава, чай, цукор
	Вивід статистики наявності складових для приготування напоїв
	Зміна цін на напої
	Вилучення кешу
У режимі користувача передбачити 		
Замовлення напою(+ оплата)	
 */
using System;

Console.WriteLine("----------- Welcome -----------");

Console.WriteLine("\tMenu:");
Console.WriteLine("1. Load components");
Console.WriteLine("2. Display statistics on the availability of ingredients");
Console.WriteLine("3. Change drink prices");
Console.WriteLine("4. Withdraw cash");
Console.WriteLine("5. Add drink");
Console.WriteLine("6. Save to file");
Console.WriteLine("7. Load from file");
Console.WriteLine("8. Show all drinks");
Console.WriteLine("9. Find drink");
Console.WriteLine("10. Delete drink");

Console.Write("Your choice:");
int choice = int.Parse(Console.ReadLine());


switch (choice)
{
	case 5:
		var drink = new Drink();

        Console.Write("Enter drink name:");
        drink.name = Console.ReadLine();

        Console.Write("Enter drink price:");
        drink.price = double.Parse(Console.ReadLine());

        Console.Write("Enter drink size:");
        drink.size = int.Parse(Console.ReadLine());









        break;

	case 8:
        break;
}

public class Drink
{
	public string name;
	public int size;
	public double price;
}







