void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

DrawText("Intensive C# Demo text", 629, 360); // магические числа

string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;  // left
int screenHeightPosition = Console.WindowHeight / 2; // top

DrawText(caption, screenWidthPosition, screenHeightPosition);

DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
    );