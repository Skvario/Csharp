/// Random rnd = new Random ();
// тип    имя   создание объекта
// int value = rnd.Next(1, 10); 
/*
Random rnd = new Random();

int size = 100;
int[] arr_int = new int[size];
int i = 0;
while(i < size)
{
    arr_int[i] = rnd.Next(1, 10);
    i = i + 1;
}
i = 0;
while(i < size)
{
    Console.Write($"{arr_int[i]} ");
    i = i + 1;
} */

// string input = Console.ReadLine();
// вводит значение в строковом формате
// int value = Convert.ToInt32(input);
/*
Console.WriteLine("Enter integer number");

string input = Console.ReadLine();

int value = Convert.ToInt32(input);
*/

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while(i < size)
{
    Console.WriteLine("Enter integer number");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i++;
}