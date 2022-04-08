void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
    collection[index] = new Random().Next(1, 10);
    index++;
}

}

void PrintArray(int [] collection)
{
int count  = collection.Length;
int position = 0;
while (position<count)
{
Console.WriteLine(collection[position]);
position++;
}

}

int IndexOf(int[] collection, int find)
{
int count = collection.Length;
int index = 0;
int position = 0;
while (index < count)
{
  if(collection[index] == find)
  {
    position = index;
    break;
  }
    index++;
}
return position;
}

int [] array = new int[10];

FillArray(array);
array [4] = 4;
array [6] = 6;  
PrintArray(array);
Console.WriteLine();

int position = IndexOf(array, 4);
Console.WriteLine(position);
