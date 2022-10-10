Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
string n2 = (n).ToString(); 
if(n > 99)
    Console.WriteLine(n2[2]);
if(n < 100)
    Console.WriteLine("Третьей цифры нет");