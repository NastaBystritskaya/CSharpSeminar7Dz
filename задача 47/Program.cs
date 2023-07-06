// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[,] GetArray(){
    int[,] Massive = new int[3, 4];
    for(int j = 0; j < 3; j++) {
        for (int i = 0; i < 4; i++)
        {
            Massive[j, i] = new Random().Next(-9, 10);
        }
    }
    return Massive;
}

void PrintArray(int[,] Massive) {
    for(int j = 0; j < 3; j++) {
        for (int i = 0; i < 4; i++)
        {
            System.Console.Write($"{Massive[j, i]} ");
        }
        System.Console.WriteLine();
    }
}
void Main() {
    int[,] array = GetArray();
    PrintArray(array); 
}

Main();