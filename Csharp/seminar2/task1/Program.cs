// задача, которая принимает на вход трёхзначное число,
// а на выходе удаляет вторую цифру этого числа
// a=256=>26
// a = 891=>81
Console.WriteLine("enter your number: ");
// string? num = Console.Readline();
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 99 && num1 <= 999)
{
    int num2 = num1 / 100;
    int num3 = num1 % 10;
    int result = num2 * 10 + num3;
    Console.Write(result);
}
else
{
    Console.Write("your numb is not 3 digit , motherfucker!");
}
