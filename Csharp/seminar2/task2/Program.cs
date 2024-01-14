// программа принимает на вход 3х значное число,
// на выходе оставляет 2ю цифру возведённую в 
// степень 3ей цифры
// 487=> 8^7
// 254=> 5^4


int numt2 = 123;
// 87 % 100 => 87
// 87 / 10 => 8
// 87 % 10 => 7

int dig2 = numt2 / 10 % 10;
int dig3 = numt2 % 10;
// 8^7 = 8*8*8*8*8*8*8
int ind = 0;
int multy = 1;
 while(ind < dig3){
    multy *= dig2; // multy=multy*dig2
    ind++;
 }
 
 double resultnumt2 = Math.Pow(dig2,dig3);

 Console.WriteLine(multy);
 Console.WriteLine(resultnumt2);