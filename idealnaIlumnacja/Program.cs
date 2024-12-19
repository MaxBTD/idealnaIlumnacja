
namespace idealnaIlumnacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int.TryParse(Console.ReadLine(), out int n);
            int[,] tablcaSwiatel = new int[n + 1, n + 1];
            int.TryParse(Console.ReadLine(), out int k);
            for(int i = 0; i < k; i++)
            {
                string[] komenda = Console.ReadLine().Split(' ');
                int x1 = int.Parse(komenda[1]);
                int y1 = int.Parse(komenda[2]);
                int x2 = int.Parse(komenda[3]);
                int y2 = int.Parse(komenda[4]);

                for(int j = x1; j <= x2; j++)
                {
                    for(int l = y1; l <= y2; l++)
                    {
                        tablcaSwiatel[j, l] = komenda[0] == "1" ? 1 : 0;
                    }
                }
            }

            for (int i = 0; i < (n + 1); i++)
            {
                for (int j = 0; j < (n + 1); j++)
                {
                    if(tablcaSwiatel[i, j] == 1)
                        count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
