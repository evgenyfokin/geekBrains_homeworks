void task_41() {
    // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    Console.WriteLine("Set the length of your array");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray(numbers, size);
    PrintArray(numbers, size);
    CalculatePositiveNums(numbers, size);
}

void FillArray(int [] arr, int size) {
    for (int i = 0; i < size; i++) {
        Console.WriteLine($"Enter {i + 1} number:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int [] arr, int size) {
    Console.WriteLine("Your array:");
    for (int i = 0; i < size; i++) {
        Console.Write($"{arr[i]}; ");
    }
    Console.WriteLine();
        Console.WriteLine();
}

void CalculatePositiveNums(int [] arr, int size) {
    int acc = 0;
    for (int i = 0; i < size; i++) {
        if (arr[i] > 0) {
            acc++;
        }
    }
    Console.WriteLine($"Your array contains {acc} positive number(s).");
}

// task_41();

void task_43() {
//     Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    Console.WriteLine("Enter coordinate parameters");
    Console.WriteLine("k1:");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("b1:");
    int b1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("k2:");
    int k2 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("b2:");
    int b2 = Convert.ToInt32(Console.ReadLine());
    DetermCoords(k1, k2, b1, b2);
}

void DetermCoords(int k1, int k2, int b1, int b2) {
    int x = (b2 - b1)/(k1 - k2);
    int y = k1 * x + b1;
    Console.WriteLine($"X: {x}; Y: {y};");
}

// task_43();