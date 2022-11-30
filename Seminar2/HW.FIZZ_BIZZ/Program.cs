int num=1;
while (num<=100) 
{   if(num%15==0) Console.Write ("FizzBuzz ");
    else if (num%3==0) Console.Write ("Fizz ");
    else if(num%5==0) Console.Write ("Buzz ");
    else    Console.Write ($"{num} ");
num++;
}
