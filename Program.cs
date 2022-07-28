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


int Input(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


