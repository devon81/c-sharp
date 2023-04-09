int[] array = {81,62,53,24,15,66,73,81}; 
int n = array.Length; 
int find = 81;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
         Console.WriteLine(index);
          break;
    }
   
    index = index +1;
}

