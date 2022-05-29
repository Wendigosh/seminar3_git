int num = new Random().Next(100, 1000);
Console.WriteLine(num);

double  firstDigit = num / 100;
double thirdDigit = num % 10;
Console.Write(firstDigit);
Console.Write(thirdDigit);

