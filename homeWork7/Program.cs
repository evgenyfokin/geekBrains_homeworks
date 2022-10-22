void task_47() {
    // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
    Console.WriteLine("Enter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of colums");
    int colums = Convert.ToInt32(Console.ReadLine());
    double [,] numbers = new double[rows, colums];
    FillArray(numbers);
    PrintArr(numbers);
}

void FillArray(double [,] arr) {
    Random random = new Random();
    int rows = arr.GetLength(0);
    int colums = arr.GetLength(1);
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < colums; j++) {
            arr[i, j] = Math.Round(random.NextDouble() * 50 - 25, 1);
        }
    }
}

void PrintArr(double[,] arr) {
    int rows = arr.GetLength(0);
    int colums = arr.GetLength(1);
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < colums; j++) {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// task_47();

void task_50() {
    // Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    int rows = 5;
    int colums = 5;
    Console.WriteLine("Enter the first index");
    int firstIndex = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second index");
    int secondIndex = Convert.ToInt32(Console.ReadLine());
    double [,] numbers = new double[rows, colums];
    FillArray(numbers);
    PrintArr(numbers);
    FindValue(numbers, firstIndex, secondIndex);
}

void FindValue(double[,] arr, int firstIndex, int secondIndex) {
    if(firstIndex > arr.GetLength(0) || secondIndex > arr.GetLength(1)) {
        Console.WriteLine("There is no such number in the array");
    }
    else {
        Console.WriteLine(arr[firstIndex, secondIndex]);
    }
}

// task_50();

void task_52() {
    // Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Random random = new Random();
    int rows = random.Next(3, 7);
    int colums = random.Next(4, 9);
    int[,] numbers = new int[rows, colums];
    FillIntegerArray(numbers);
    PrintIntegerArray(numbers);
    CalculateArithmeticMean(numbers);
}

void FillIntegerArray(int[,] arr) {
    Random random = new Random();
    int rows = arr.GetLength(0);
    int colums = arr.GetLength(1);
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < colums; j++) {
            arr[i, j] = random.Next(-5, 5);
        }
    }
}

void PrintIntegerArray(int[,] arr) {
    int rows = arr.GetLength(0);
    int colums = arr.GetLength(1);
    Console.WriteLine("Array:");
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < colums; j++) {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void CalculateArithmeticMean(int[,] arr) {
    int rows = arr.GetLength(0);
    int colums = arr.GetLength(1);
    Console.WriteLine();
    Console.WriteLine("Arithmetic mean:");
    for(int i = 0; i < colums; i++) {
        double temp = 0;
        for(int j = 0; j < rows; j++) {
            // Console.Write($"{arr[j, i]}; ");
            temp = temp + arr[j, i];
        }
        Console.Write(Math.Round(temp / rows, 2) + "\t");
    }
}

// task_52();