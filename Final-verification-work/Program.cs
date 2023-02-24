// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.WriteLine();


Console.WriteLine("Введите длину массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int needLength = 3;
int n = 0;


string [] array = AskArray();
string [] finalArray = FindLessThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", finalArray)}]");


string[] FindLessThan(string[] input, int n) {
    string[] output = new string[arrayLength];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}


string[] AskArray() {
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}
