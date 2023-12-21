// программа которая принимает два числа и проверяет является ли первое число квадратом второго

// int first_number = 25;
// int second_number = 5;

// if(second_number*second_number == first_number){
//     Console.Write("first num is quater of second num ");
// }
// else{
//     Console.Write("first num isn't quarter of second num");
// }

// напишите переменную которая на вход принимает
// целое число N , а на выходе показывает все целые числа в промежутке от -N до N

int num = 5;
int num2 = num * (-1);

while(num2<=num){
    Console.Write($"{num2} ");
    num2++;
}