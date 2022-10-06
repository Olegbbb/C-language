int[] array = {15,92,13,49,18,51,56,27,18};

int n = array.Length;
int find = 18;

for(int index = 0; index < n; index++  )
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
}
