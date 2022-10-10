Console.WriteLine("Введите цифру дня недели ");
int n = Convert.ToInt32(Console.ReadLine());

if(n == 6 || n == 7)
    Console.WriteLine("Выходной день");
if(n == 5 || n == 4 || n == 3 || n == 2 || n == 1)
    Console.WriteLine("Будний день");
if(n < 1 || n > 7)
    Console.WriteLine("Не день недели");