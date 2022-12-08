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

// // текст, работа с текстом
// Дан текст. в тексте нужно все пробелы заменить черточками,
// маленькте буквы к заменить большими К
// а большие С заменить маленькми с.
// Ясна ли задача?

string text = " - Я думАю, - сказАл князь, улыбаясь, - что, "
            + "новАя строка";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'А', 'а');
Console.WriteLine(newText);

// Алгоритм сортировки методом выбора - найти позицию минимального элемента

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr); // упорядочивание массива
PrintArray(arr);
Console.WriteLine();
Console.WriteLine();

// максимальный элемент

int[] arr1 = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray1(int[] array1)
{
    int count = array1.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort1(int[] array1)
{
    for (int i = 0; i < array1.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array1.Length; j++)
        {
            if (array1[j] > array1[maxPosition]) maxPosition = j;
        }

        int temporary1 = array1[i];
        array1[i] = array1[maxPosition];
        array1[maxPosition] = temporary1;
    }
}
PrintArray1(arr1);
SelectionSort1(arr1); // упорядочивание массива
PrintArray1(arr1);
