
int[] numbers = new int[40];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
    numbers[i] = rand.Next(1, 100);
Thread.Sleep(300);

int temp;

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers.Length - 1 - i; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }

}
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

