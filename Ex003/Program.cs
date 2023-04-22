int [] array = {1, 34, 64, 33, 23, 11, 65, 61};

int size = array.Length;
int find = 23;

int index = 0;

while (index < size)
{
    if (array[index] == find);
    {
        Console.WriteLine(index);
    }
    // index = index + 1;
    index++;
}