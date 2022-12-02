Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n/10000 % 10;
int n2 = n/1000%10;
int n4 = n/10%10;
int n5 = n%10;
if( n>99999 || n<10000) Console.WriteLine("Неверное число");
else if (n1==n5 && n2==n4) Console.WriteLine("Паллиндром");
else Console.WriteLine("не паллиндром");   