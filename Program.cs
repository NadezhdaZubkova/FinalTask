// Написать программу, которая из имеющегося массива строк формитрует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При  решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно символами.
//Примеры: 
//["hello","2","world",":-)"] -> ["2",":-)"]
//["1234","1567","-2","computer science"]->["-2"]
//["Russia","Denmark","Kazan"]->[]

string [] TestArray1= {"hello","2","world",":-)"};
string [] TestArray2= {"1234","1567","-2","computer science"};
string [] TestArray3= {"Russia","Denmark","Kazan"};

PrintArray(TestArray1);
string [] NewArrey1 = FindArray(TestArray1);
PrintArray(NewArrey1);
Console.WriteLine();
PrintArray(TestArray2);
string [] NewArrey2 = FindArray(TestArray2);
PrintArray(NewArrey2);
Console.WriteLine();
PrintArray(TestArray3);
string [] NewArrey3 = FindArray(TestArray3);
PrintArray(NewArrey3);


int CountSearch(string[]input) //поиск числа искомых строк
{
    int count=0;
    for (int i =0; i<input.Length;i++)
    {
        if (input[i].Length<=3) count++;
    }
    return count;
}

string [] FindArray(string[]input) // Создание и заполнение нового массива
{
    string[]output= new string[CountSearch(input)];
    int j=0;
    int i=0;
    while (i<input.Length)
    {
        if (input[i].Length<=3)
        {
            output[j]=input[i];
            j++;
        }
        i++;
    }
    return output;
}

void PrintArray(string[] array) // Печать массива
{
    if (array.Length==0)
    {
        Console.WriteLine($"Array is empty");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
    }
}



