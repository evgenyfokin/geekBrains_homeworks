// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void isPalindrome() {
    Console.WriteLine("Enter a number");
    int userNum = Convert.ToInt32(Console.ReadLine());
    string result = "";
    int decrement = 0;
    int duplicateUserNum = userNum;
    while (duplicateUserNum > 0) {
        decrement = duplicateUserNum % 10;
        result = result + $"{decrement}";
        duplicateUserNum = duplicateUserNum / 10;
    }
    int resultToNum = Convert.ToInt32(result);
    if (userNum == resultToNum) {
        Console.WriteLine($"{userNum} is a palindrome");
    }
    else {
        Console.WriteLine($"{userNum} is not a palindrome");
    }
}

// isPalindrome();

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void getCoords() {
    Console.WriteLine("Enter point A coordinates");
    Console.WriteLine("X ->");
    int aX = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y ->");
    int aY = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Z ->");
    int aZ = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter point B coordinates");
    Console.WriteLine("X ->");
    int bX = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y ->");
    int bY = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Z ->");
    int bZ = Convert.ToInt32(Console.ReadLine());

    calculateDistance(aX, aY, aZ, bX, bY, bZ);
}

void calculateDistance(int aX, int aY, int aZ, int bX, int bY, int bZ) {
    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2))));
}

// getCoords();


// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cube() {
    Console.WriteLine("Enter a number");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    int calculator = 1;
    while (calculator <= userNumber) {
        Console.WriteLine($"{calculator} -> {Math.Pow(calculator, 3)}");
        calculator++;
    }
}
// cube();