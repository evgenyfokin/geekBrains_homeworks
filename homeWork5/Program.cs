// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void task_34 ()  {
    int size = 10;
    int[] numbers = new int[size];
    fillArray(numbers, size, 100, 1000);
    printArray(numbers, size);
    checkEven(numbers, size);
}

void fillArray(int[] arr, int size, int from, int to) {
    Random random = new Random();
    for(int i = 0; i < size; i++) {
    arr[i] = random.Next(from, to);
    }
}

void printArray(int[] arr, int size) {
    Console.WriteLine("Array: ");
    for(int i = 0; i < size; i++) {
        Console.Write($" {arr[i]};");
    }
}

void checkEven(int[] arr, int size) {
    int acc = 0;
    for(int i = 0; i < size; i++) {
        if(arr[i] % 2 == 0) {
            acc++;
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine($"There are {acc} even numbers in the array.");
}

// task_34();

//-------------------------------------------------------







// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void task_36() {
    int size = 10;
    int[] numbers = new int[size];
    fillArray(numbers, size, 1, 10);
    printArray(numbers, size);
    sumOddNums(numbers, size);
}

void sumOddNums(int[] arr, int size) {
    int sum = 0;
    for (int i = 0; i < size; i++) {
        if (i % 2 == 0 || i == 0) {
            sum = sum + arr[i];
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine($"The sum of all numbers with even indices in the array is {sum}.");
}

// task_36();

//-------------------------------------------------------







// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95

void task_38() {
    int size = 10;
    double[] numbers = new double[size];
    fillArrayFractionally(numbers, size);
    printFractionalArray(numbers, size);
    calculateDiff(numbers, size);
}

void fillArrayFractionally(double[] arr, int size) {
    Random random = new Random();
    for (int i = 0; i < size; i++) {
        arr[i] = Math.Round(random.NextDouble() * 50 - 25, 3);
    }
}

void printFractionalArray(double[] arr, int size) {
    for (int i = 0; i < size; i++) {
        Console.Write($"{arr[i]}; ");
    }
}

void calculateDiff(double[] arr, int size) {
    double temp = 0;
    double max = 0;
    double min = 0;
    for (int i = 0; i < size; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
        temp = max;
    }
    for (int i = 0; i < size; i++) {
        if (arr[i] < temp) {
            temp = arr[i];
        }
        min = temp;
    }
    Console.WriteLine(" ");
    Console.WriteLine($"MAX: {max}");
    Console.WriteLine($"MIN: {min}");
    Console.WriteLine($"MAX - MIN = {Math.Round(max - min, 3)}");
}

// task_38();

//-------------------------------------------------------