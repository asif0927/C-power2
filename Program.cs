int num = int.Parse(Console.ReadLine());
int powerful = 1;
int result = 2;
while (powerful <= 100 && result != num)
{
    result *= 2;
    powerful++;
}
if (result == num)
{
    Console.WriteLine("2-nin quvvetidir");
}
else
{
    Console.WriteLine("2-nin quvveti deyil");
}
