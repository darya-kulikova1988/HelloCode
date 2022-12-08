// вид 1 - не принимает и не возвращает
void Method1()
{
    Console.WriteLine("Автор");
}
Method1();
// Method1; нужны скобки!!!



// Вид 2 - ничего не возвращает, но может прнимать аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);