string[] array = { "df", "2377", "384", "4500", "FSB", "GB" };
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("[]");
}
else
{
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && j < count)
        {
            newArray[j] = array[i];
            Console.Write(newArray[j] + "\t");
            j++;
        }
    }
}