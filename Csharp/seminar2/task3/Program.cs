//  программа принимает на вход два числа,
// и выводит является ли второе чило кратным 
// первому, если нет , то выводит остаток от деления

int first = 3;
int second = 19;
int third = second % first ;

if(third == 0){
    Console.WriteLine("yes");
}
else{
    Console.WriteLine($"no, {third}"); 
    Console.WriteLine($"no, {second % first}");  
}
