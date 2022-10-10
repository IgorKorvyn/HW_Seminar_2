Console.WriteLine("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 100 || n > 999)
{
Console.WriteLine("Введенное число не трехзначное, введите трехзначное число"); 
}
else
{
Console.Write(((n%100) - (n%10)) / 10);
}