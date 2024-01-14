// int N = 9542;
// if (N < 10)
// {
// Console.WriteLine(N);
// }
// else
// {
//     int testCount = N;
//     int count = 0;
//     while(testCount > 0){
//         testCount/=10;
//         count++;
//     }
//     while (N > 0)
//     {
//         double delim = Math.Pow(10,Convert.ToDouble(count-1));
//         int currentDigit = N / Convert.ToInt32(delim);
//         N %= Convert.ToInt32(delim);
//         count--;
//         if (N > 0)
//         {
//         Console.Write(currentDigit + ",");
//         }
//         else
//         {
//         Console.WriteLine(currentDigit);
//         }
//     }
// }

// int num = 9542;
// int count = 0;
// int num1 = num;
// while (num1 > 10)
// {
//     num1 = num1 / 10;
//     count = count + 1;
// }
// while (count > 0)  //(count >= 0)
// {
//     int x = Convert.ToInt32(Math.Pow(10, count));
//     count = count - 1;
//     int numResult = num / x % 10;
//     Console.Write(numResult + ",");
// }
// Console.Write(num % 10);

// int num = 9542;
// int count = 0;
// int num1 = num;
// while (num1 > 10)
// {
//     num1 = num1 / 10;
//     count = count + 1;
// }
// while (count > 0)  //(count >= 0)
// {
//     int x = Convert.ToInt32(Math.Pow(10, count));
//     count = count - 1;
//     int numResult = num / x % 10;
//     Console.Write(numResult + ",");
// }
// Console.Write(num % 10);

// напишите программу, которая выводит третью цифру 
// с конца заданного числа или сообщает,
// что третьей цифры нет

int num = 98777456;

if(num > 99){
    while(num > 999)
    {
        num = num / 10;
    }
    int dig3 = num % 10;
    Console.WriteLine(dig3);
}
else{
    Console.Write("Your number has less than three digits");
}





