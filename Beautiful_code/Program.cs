// void DrawText(string text, int left, int top)
// {
//     Console.SetCursorPosition(left, top);
//     Console.WriteLine(text);
// }

// DrawText("Intensive C# Demo text", 629, 360); // магические числа

// string caption = "Intensive C# Demo text";
// int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;  // left
// int screenHeightPosition = Console.WindowHeight / 2; // top

// DrawText(caption, screenWidthPosition, screenHeightPosition);

// DrawText(
//     text: caption,
//     left: screenWidthPosition,
//     top: screenHeightPosition
//     );


using System.Linq;

string text = "(1,2) (2,3) (3,4) (4,1)"
            .Replace("(", "")
            .Replace(")", "")
            ;
Console.WriteLine(text);

var data = text.Split(" ")
            .Select(item => item.Split(','))
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
            .Where(e => e.x % 2 == 0)
            .Select(point => (point.x * 2, point.y))
            .ToArray();

for (int i = 0; i < data.Length; i++)
{
    // Console.WriteLine(data[i].x * 2);
    Console.WriteLine(data[i]);
    // Console.WriteLine();
    // for (int k = 0; k < data[i].Length; k++)
    // {
    //     Console.WriteLine(data[i][k]);
    // }

    Console.WriteLine();
}