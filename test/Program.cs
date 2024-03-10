//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Пример:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

int size = 5;
int n = 3;
string[] array1 = new string [size];

void FillArray(string[] array)
{
    for (int i = 0; i < size;i++)
    {
        System.Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = System.Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length;i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("]");
}

int GetSizeArray(string[] array)
{
  int size2 = 0;
  for (int i = 0; i < array.Length;i++)
  {
    if(array[i].Length <=n) {
    size2++;}
  }
return size2;
}


string[] MakeNewArray(string[] array) {
 string[] array2 = new string [GetSizeArray(array1)];
  
  int j = 0;
    for (int i = 0; i < array.Length;i++)
  {
    if(array[i].Length <= n)
    {
        array2[j] = array[i];
        j++;
    }
  }
  return array2;
}


FillArray(array1);
PrintArray(array1);

if (GetSizeArray(array1) == 0){
    System.Console.WriteLine("Элементов нового массива нет");
}
else{
    string[] array2 = new string [GetSizeArray(array1)];
    array2 = MakeNewArray(array1);
    System.Console.Write(" -> ");
    PrintArray(array2);
}

