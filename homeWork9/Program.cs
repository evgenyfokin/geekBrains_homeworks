void task_64() {
    // Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    Console.WriteLine("Enter the first number:");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the last number:");
    int lastNum = Convert.ToInt32(Console.ReadLine());
    GetMultsOfThree(firstNum, lastNum);
}

void GetMultsOfThree(int firstNum, int lastNum) {
    if (firstNum > lastNum) {
        return;
    }
    if (firstNum % 3 == 0){
        Console.Write($"{firstNum}; ");
        firstNum = firstNum + 3;
    } else {
        firstNum++;
    }
    
    GetMultsOfThree(firstNum, lastNum);
}

// task_64();

void task_66() {
    // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    Console.WriteLine("Enter the first number");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the last number");
    int lastNum = Convert.ToInt32(Console.ReadLine());
    SumInt(firstNum, lastNum);
}

void SumInt(int firstNum, int lastNum, int sum = 0) {
    if (firstNum > lastNum) {
        Console.WriteLine($"Result: {sum}");
        return;
    }
    sum = sum + firstNum;
    firstNum = firstNum + 1;
    SumInt(firstNum, lastNum, sum);
}

// task_66();

void task_68() {
    // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    
    Console.WriteLine("Enter number M:");
    int numM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number N:");
    int numN = Convert.ToInt32(Console.ReadLine());

    int ackermannFunc (int numM, int numN) {
        if (numM == 0) {
            return numN + 1;
            }
        if (numM != 0 && numN == 0) {
            return ackermannFunc(numM - 1, 1);
            }
        if (numM > 0 && numN > 0) {
            return ackermannFunc(numM - 1, ackermannFunc(numM, numN - 1));
            }
        return ackermannFunc(numM, numN);
    }

    Console.WriteLine($"Ackermann function for numbers ({numM},{numN}) = {ackermannFunc(numM, numN)}");
    
}

// task_68();