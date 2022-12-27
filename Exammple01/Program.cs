// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.Clear();

Console.Write("Сколько элементов вы хотите проверить? Введите целое число и нажмите enter: ");
int userNum = int.Parse(Console.ReadLine() ?? "");
string[] userArray = FillArray(userNum);

Console.WriteLine($"[ {String.Join(" ", userArray)} ]");


// метод для заполнения массива длиной n пользовательскими значениями
string[] FillArray(int n)
{
    string[] filledArray = new string[n];
    Console.WriteLine($"Введите {n} элемента/ов:");
    for (int i = 0; i < n; i++) filledArray[i] = Console.ReadLine() ?? "";    
    return filledArray;
}

