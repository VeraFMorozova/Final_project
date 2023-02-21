// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color; 
    Console.Write(data);
    Console.ResetColor();
}
int getUserData(string message)
{
   printInColor(message + "\n",ConsoleColor.DarkGreen);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
void print(string [] array, int length)
{
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] );
         if(i < array.Length - 1)
         {
            Console.Write(", ");
         }
    }
     Console.Write("]");
}

string [] getArray (int length)
{
    string [] array = new string [length];
    for (int i = 0; i < length; i++)
    {
        printInColor("Введите элемент массива" + "\n",ConsoleColor.DarkGreen);
        array[i] = Console.ReadLine();
    }
    return array;
}
string [] getNewArray (string [] array)
{
    string [] arr = new string [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[i]=array[i];
        }
    }
    return arr;
}

int number = getUserData("Введите количество элементов массива");
string [] array = getArray (number);
print (array, number);
string [] NewArray = getNewArray(array);
print(NewArray, NewArray.Length);