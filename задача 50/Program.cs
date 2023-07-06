// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(){
    int[,] Massive = new int[3, 4];
    for(int j = 0; j < 3; j++) {
        for (int i = 0; i < 4; i++)
        {
            Massive[j, i] = new Random().Next(-10, 11);
            System.Console.Write($"{Massive[j, i]} ");
        }
        System.Console.WriteLine();
    }
    return Massive;
}

void GetPosition(int[,] Massive, int j, int i) {
    if (j < 3 && i < 4) {
        System.Console.WriteLine(Massive [j,i]);
    }
    else {
        System.Console.WriteLine("Такого числа в массиве нет");
    }
}

int GetUserInput(String text) {
    System.Console.WriteLine(text);
    int result = int.Parse(System.Console.ReadLine()!);
    return result;
}

void Main() {
    int[,] array = GetArray();
    int row = GetUserInput("Введите номер строки: ");
    int column = GetUserInput("Введите номер столбца: ");
    GetPosition(array, row, column);
}

Main();

