//**Задача:** Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длинна которых меньше либо равна 3 символа. 
//Первоночальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуеться пользоваться коллекиями, 
//лучше обойтись исключительно массивами.


string start = "";

while (start.ToLower() != "y" && start.ToLower() != "n")
{
  Console.Write("Ввести массив в ручную? (y/n): ");
  start = Console.ReadLine();
}

string[] arrayScan = new string[]  {};

if (start.ToLower() == "y") {
  int arrayLong = Input("Введите количество элементов массива: ");
  arrayScan = new string[arrayLong];
  for (int i = 0; i < arrayScan.Length; i++)
  {
    Console.Write($"Введите элимент {i+1}: ");
    arrayScan[i] = Console.ReadLine();
  }
}
else 
{
  arrayScan = new string[]  {"hello", "2", "world", ":-)"};
}

int lengthMax = 3;
int count = 0;

string[] arrayResult = new string[arrayScan.Length];
ScanArray(arrayScan, arrayResult, lengthMax);
Console.WriteLine($"{PrintArray(arrayResult)}");


void ScanArray(string[] arrayTaken, string[] arrayNew, int lengthMax)
{

    for (int i = 0; i < arrayTaken.Length; i++)
    {
    if(arrayTaken[i].Length <= lengthMax)
        {
        arrayNew[count] = arrayTaken[i];
        count++;
        } 
    }
}

string PrintArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < count; i++)
  {
    result += $"{array[i]}";
    if (i < count - 1) 
    result += ", ";
  }
  result += " ]";
  return result;
}


int Input(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


