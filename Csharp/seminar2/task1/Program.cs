// задача, которая принимает на вход трёхзначное число,
// а на выходе удаляет вторую цифру этого числа
// a=256=>26
// a = 891=>81

int num = 23;
if(num > 99 && num <= 999){
    int num1 = num / 100;
    int num3 = num % 10;
    int result = num1 * 10 + num3;
    Console.Write(result);
}
else{
    Console.Write("your numb is not 3 digit , motherfucker!");
}
