//Задание Opposite
int n = Convert.ToInt32(Console.ReadLine());
int[] counts = new int[n];
int y;

for (int i = 0; i < n; i++)
{
    y = Convert.ToInt32(Console.ReadLine());
    counts[i] = y;
}

if (n >= 1 && n <= 100)
{
    isOpposite(counts);
}

void isOpposite(int[] m)
{
    for (int i = 0; i < m.Length; i++)
    {
        for (int j = 0; j < m.Length; j++)
        {
            if (m[i] == m[j] * -1)
            {
                Console.Write(i);
                Console.Write(j);
                return;


            }
        }
    }
}

//Задание isMatrixSymmetric
int x = Convert.ToInt32(Console.ReadLine()); int[,] matrix = new int[x, x];
int z;
if (x <= 100)
{
    Create(matrix); Print(matrix);
    isMatrixSymmetric(matrix);
}
else { return; }
void Create(int[,] m)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            z = Convert.ToInt32(Console.ReadLine());
            matrix[i, j] = z;
        }
        Console.WriteLine();
    }
}

void Print(int[,] m)
{
    for (int i = 0; i < x; i++)
    {
        for (int k = 0; k < x; k++)
        {
            Console.Write(matrix[i, k] + " ");
        }
        Console.WriteLine();
    }
}
bool isMatrixSymmetric(int[,] m)
{
    bool prosto = false;
    int count = 0; for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            if (i != j)
            {
                if (m[i, j] == m[j, i])
                {
                    count++;
                }
            }
        }
    }
    if (count == x) { prosto = true; Console.WriteLine("yes"); }
    if (prosto == false) { Console.WriteLine("no"); }
    return prosto;
}


//Задание LocalMaxMin
int r = Convert.ToInt32(Console.ReadLine()); 
int[] days = new int[r];
int o;
for (int i = 0; i < n; i++)
{
    o = Convert.ToInt32(Console.ReadLine()); 
    days[i] = o;
}
if (r >= 3)
{
    maxMin(days);
}
void maxMin(int[] m)
{
    for (int i = 1; i < r - 1; i++)
    {
        if (m[i - 1] > m[i] && m[i] < m[i + 1])
        {
            Console.WriteLine($"day {i + 1} : {m[i]} (min)");
        }
        else if (m[i - 1] < m[i] && m[i] > m[i + 1])
        {
            Console.WriteLine($"day {i + 1} : {m[i]} (max)");
        }
    }
}


