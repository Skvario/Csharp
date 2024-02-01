//int n = 10;
int[] array = { 2, 5, 4, 7, 6, 23, 78, 53, 22, 23 };
int i = 0;
while(i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");    
    }
    i = i + 1;
}


