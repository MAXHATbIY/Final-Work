// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.Clear();

Console.Write("Сколько элементов вы хотите проверить? Введите целое число и нажмите enter: ");
int userNum = int.Parse(Console.ReadLine() ?? "");
string[] userArray = FillArray(userNum);

string[] finalArray = DeleteLongElements(userArray, 3);   //новый массив с элементами длиной не более 3 символов

Console.WriteLine($"[ {String.Join(" ", userArray)} ]  -> [ {String.Join(" ", finalArray)} ]");



// метод для заполнения массива длиной n пользовательскими значениями
string[] FillArray(int n)
{
    string[] filledArray = new string[n];
    Console.WriteLine($"Введите {n} элемента/ов:");
    for (int i = 0; i < n; i++) filledArray[i] = Console.ReadLine() ?? "";    
    return filledArray;
}

// метод для получения нового массива, содержащего элементы исходного массива длиной не более трех символов
string[] DeleteLongElements(string[] inArray, int num)
{
    int count = 0;
    int[] positions = new int[inArray.Length];   
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= num) 
        {
            positions[count] = i;
            count++;
        }
    }

    string[] resultArray = new string[count];   // создаем новый массив длиной count
    for (int j = 0; j < count; j++) resultArray[j] = inArray[positions[j]];   // записываем в новый массив выбранные элементы
    
    return resultArray;
}