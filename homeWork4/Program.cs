// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

void task25() {
    Console.WriteLine("Enter the first number");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    int secondNum = Convert.ToInt32(Console.ReadLine());
    int acc = firstNum;
    for (int i = 1; i < secondNum; i++) {
       acc = firstNum * acc;
    }
    Console.WriteLine(acc);
}

// task25();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void task27(){
    Console.WriteLine("Enter a number");
    int num = Convert.ToInt32(Console.ReadLine());
    int acc = 0;
    for (int i = 0; num > 0; i++) {
        acc = acc + num % 10;
        num = num / 10;
    }
    Console.WriteLine(acc);
}

// task27();

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

void task29() {
    int size = 8;
    int[] numbers = new int[size];
    fillArray(numbers, size);
    separateArray(numbers, size);
}

void fillArray(int[] arr, int size) {
    Random random = new Random();
    for(int i = 0; i < size; i++) {
    arr[i] = random.Next(-9, 9);
    }
}

void printArray(int[] arr, int size) {
    for(int i = 0; i < size; i++) {
        Console.Write($" {arr[i]};");
    }
}

void separateArray(int[] arr, int size) {
    int temp = 0;
    for (int i = 1; i < size; i++) {
        for (int j = 0; j < size - i; j++) {
            if(arr[j] * arr[j] / 2 > arr[j+1] * arr[j+1] / 2 || arr[j+1] == 0) {
                temp = arr[j+1];
                arr[j+1] = arr[j];
                arr[j] = temp;
            }
        }
    }
    printArray(arr, size);
}

// task29();