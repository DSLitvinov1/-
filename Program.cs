//  Задача 1.

using System;

class Program {
    static void Main() {
        
        int M = 5;
        int N = 10;

        
        PrintNaturalNumbers(M, N);
    }

    static void PrintNaturalNumbers(int current, int end) {
        
        if (current > end) {
            return;
        }

        
        Console.WriteLine(current);

        
        PrintNaturalNumbers(current + 1, end);
    }
}




// Задача 2.


using System;

class Program {
    static void Main() {
        
        int m = 2;
        int n = 3;

        
        int result = AckermannFunction(m, n);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }

    static int AckermannFunction(int m, int n) {
        
        if (m == 0) {
            return n + 1;
        }
        
        else if (n == 0) {
            return AckermannFunction(m - 1, 1);
        }
        
        else {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}



// Задача 3.




using System;

class Program {
    static void Main() {
        
        int[] array = { 1, 2, 3, 4, 5 };

        
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index) {
        
        if (index < 0) {
            return;
        }

        
        Console.WriteLine(array[index]);

        
        PrintArrayReverse(array, index - 1);
    }
}
