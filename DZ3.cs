//Задание1

int[] fibonachiNumbers = new int[10];
fibonachiNumbers[0] = 0;
fibonachiNumbers[1] = 1;
for  (int i = 2; i < fibonachiNumbers.Length; i++)
{
    fibonachiNumbers[i] = fibonachiNumbers[i - 1] + fibonachiNumbers[i - 2];
}

for (int j = 0; j < fibonachiNumbers.Length; j++)
{
    Console.Write(fibonachiNumbers[j] + " ");
}

//Задание2
Console.WriteLine();

int a = 2;
int b = 20;
int[] array = new int[((b - a) / 2) + 1];

for (int i = 0; i < array.Length; i++)
{
    array[i] = 2 * (i + 1);
}

for (int j = 0; j < array.Length; j++)
{
    Console.Write(array[j] + " ");
}

//Задание3
Console.WriteLine();

int[,] countTable = new int[5, 5];

for (int i = 0; i < countTable.GetLength(0); i++)
{
    for (int j = 0; j < countTable.GetLength(1); j++)
    {
        countTable[i, j] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < countTable.GetLength(0); i++)
{
    for (int j = 0; j < countTable.GetLength(1); j++)
    {
        Console.Write(countTable[i, j] + "\t");
    }
    Console.WriteLine();
}

//Задание4
Console.WriteLine();

string password = "qwerty";
string input;

do {
    Console.Write("Введите пароль: ");
    input = Console.ReadLine();
} while (input != password);

Console.WriteLine("Пароль принят");
