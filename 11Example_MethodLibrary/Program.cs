void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.WriteLine(col[position]);
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int face = -1;
    for(int index = 0; index < count; index++)
    {
        if(collection[index]==find)
        {
            face = index;
            break;
        }
    }
    return face;
}


int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 444);
Console.WriteLine(pos);
