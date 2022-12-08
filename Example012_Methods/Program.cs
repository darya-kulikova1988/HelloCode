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
// Method21(msg: "Новый текст", count: 4);
// Method21(count: 4, msg: "самый текст");


// вид 3 - возвращают, но не принимают (тип данных должны задать)

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// вид 4 - возвращают и принимают 

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

string Method4(int count, string c)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


// таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i * j}");
    }
    Console.WriteLine();
}