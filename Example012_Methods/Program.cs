// виды методов
// Вид 1

void Method1()
{
    Console.WriteLine("Автор...");
}
// Вызов метода

//Method1();


// Вид 2

void Method2(string message)
{
    Console.WriteLine(message);
}

// Method2("Сюда выводится текст сообщения");

void Method21(string message, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(message);
        i++;
    }
}
//Method21(message: "выводимый текст", 5);
//Method21(count:4,message: "выводимый текст");

// Вид 3 
// Метод который не принимает аргументы,но возвращает значение

int Method3()
{
    return DateTime.Now.Year;
}

// Кладем возвращаемое значение в переменное и после выводим ее в Console.
int year = Method3();
//Console.WriteLine(year);


// Вид 4 
// Метод который что-то принимает и что-то возвращает

// string Method4(int count, string text)
// {
// int i = 0;
// string result = String.Empty;

// while (i < count)
// {
// result = result + text;
// i++;
// }
// return result;
// } 


string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}



string res = Method4(4, "Боря");
//Console.WriteLine(res);


// цикл в цикле


// for (int i = 1; i < 10; i++)
// {

//     for (int j = 1; j < 10; j++)
//     {
//         Console.WriteLine($"{i}x{j}={i * j}");
//     }
//     Console.WriteLine();
// }



// ======== Работа с текстом 
// Данн текст . В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3]// r - третий символ

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result= result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace (text,' ','|');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace (newText,'к','К');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace (newText,'с','С');
// Console.WriteLine(newText);

int[] arr = { 1, 2, 34, 5, 67, 6 };
void PrintArr(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr)
{

    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }

        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}

PrintArr(arr);
SelectionSort(arr);

PrintArr(arr);








