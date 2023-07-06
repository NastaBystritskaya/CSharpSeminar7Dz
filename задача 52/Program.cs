// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(){
    int[,] Massive = new int[3, 4];
    for(int j = 0; j < 3; j++) {
        for (int i = 0; i < 4; i++)
        {
            Massive[j, i] = new Random().Next(1, 11);
            System.Console.Write($"{Massive[j, i]} ");
        }
        System.Console.WriteLine();
    }
    return Massive;
}

void PrintArifmetic(int[,] Massive){
    for(int j = 0; j < 4; j++) {
        double sum = 0;
        for (int i = 0; i < 3; i++)
        {
           sum = sum + Massive[i, j];
        }
        System.Console.WriteLine(Math.Round(sum / 3, 2));
    }
}

void Main() {
    int[,] array = GetArray();
    PrintArifmetic(array);
}

Main();
