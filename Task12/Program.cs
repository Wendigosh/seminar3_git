Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(num1 % num2 == 0 ? "Число " + num1 + " кратно числу " + num2 : "Остаток от деления равен " + num1 % num2);