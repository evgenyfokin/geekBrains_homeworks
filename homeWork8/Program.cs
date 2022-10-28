void task_54() {
    // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = random.Next(4, 10);
    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
    PrintArr(numbers);
    SortArray(numbers);
}

void FillArray(int [,] arr) {
    Random random = new Random();
    int rows = arr.GetLength(0);
    int colums = arr.GetLength(1);
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < colums; j++) {
            arr[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArr(int[,] arr) {
    int rows = arr.GetLength(0);
    int colums = arr.GetLength(1);
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < colums; j++) {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int t = 0; t < arr.GetLength(1) ; t++) {
            for(int j = 0; j < arr.GetLength(1) - t -1; j++) {
            if (arr[i, j] < arr[i, j + 1]) {
                (arr[i, j], arr[i, j + 1]) = (arr[i, j + 1], arr[i, j]);
            }
        }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Array sorted in descending order:");
    PrintArr(arr);
}

// task_54();

void task_56() {
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    Random random = new Random();
    int rows = random.Next(3, 5);
    int colums = random.Next(5, 8);
    int[,] numbers = new int[rows, colums];
    FillArray(numbers);
    PrintArr(numbers);
    FindMinValue(numbers);
}

void FindMinValue(int[,] arr) {
    int minSum = 0;
    int minRow = 0;
    int temp = 0;
    for(int i = 0; i < 1; i++) {
        for(int j = 0; j <= arr.GetLength(1) - 1; j++){
            minSum =  arr[i, j] + minSum;
        }
    }
    for(int i = 0; i <= arr.GetLength(0) - 1; i++) {
        for(int j = 0; j <= arr.GetLength(1) - 1; j++){
            temp = arr[i, j] + temp;
            
        }

        if ( temp < minSum) {
            minSum = temp;
            minRow = i+1;
            
        }
        Console.WriteLine($"The sum of the values in {i + 1} row is {temp}");
        temp = 0;
        Console.WriteLine();
    }
    Console.WriteLine($"The row with minimum value is {minRow + 1} ({minSum})");
}

// task_56();

void task_58() {
    // Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4. 
    int rows = 4;
    int colums = 4;
    int[,] numbers = new int[rows, colums];
    int row = 0;
    int column = 0;
    
    for (int i = 1; i <= rows; i++) {
        // Console.WriteLine(i);
        numbers[row, column] = i;
        column++;
        // Console.WriteLine(column);
        if (column == 4) {
            for (int j = 5; j < 8; j++) {
                row++;
                column = 3;
                numbers[row, column] = j;
            }
            for (int j = 8; j < 11; j++) {
                column--;
                numbers[row, column] = j;
            }
            for (int j = 11; j < 13; j++) {
                row--;
                numbers[row, column] = j;
            }
            for (int j = 13; j < 15; j++) {
                column++;
                numbers[row, column] = j;
            }
            for (int j = 15; j < 16; j++) {
                row++;
                numbers[row, column] = j;
            }
            for (int j = 16; j < 17; j++) {
                column--;
                numbers[row, column] = j;
            }
        }
    }
    PrintArr(numbers);
    // Прошу прощения за примитивное решение, оно оказалось единственно рабочим для меня.
    
}

task_58();