int[] array = { 3, 4, 6, 8, 9,4, 12 };
int index = 0;
int n = array.Length;
int find = 4;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}