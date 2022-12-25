// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// Console.WriteLine(NumbersFor(1, 10));

// string NumbersRec(int a, int b)
// {
//     if (a < b + 1) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersRec(1, 10));


// // сумма чисел от 1 до n

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// Console.WriteLine(SumFor(10));

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumRec(10));


// // число а возвести в степень n

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }
// Console.WriteLine(PowerFor(2, 10));

// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     // if (n == 0) return 1;
//     // else return PowerRec(a, n - 1) * a;
// }
// Console.WriteLine(PowerRec(2, 10));

// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerRec(2, 10));

// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++,-5} {s[i]} {s[j]}");
//     }
// }

// int n = 1;
// void Findwords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         Findwords(alphabet, word, length + 1);
//     }
// }

// Findwords("аисв", new char[3]);

// Обход директории
// string path = "C:/Users/darya/Documents/geek brains/С#/Examples/Example001_HelloConsole";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string indent = "")  // путь, отступы
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();  // список папок
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// string path = @"C:/Users/darya/Documents/geek brains/С#/Examples/Example001_HelloConsole";
// CatalogInfo(path);

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
