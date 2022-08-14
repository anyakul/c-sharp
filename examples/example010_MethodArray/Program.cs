// № элемента массива со значением find.

int[] array = { 12, 34, 4, 15, 34, 56, 89, 34, 56 };
int n = array.Length;
int find = 4;
int index = 0;

while(index < n) 
{
    if(array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}
