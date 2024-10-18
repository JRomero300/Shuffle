using System;
using System.Linq;
using System.Threading.Tasks;

class ShuffleParallel
{

    static void Main(string[] args)
    {
        bool isExit = false;
        do
        {
            Console.WriteLine("Enter a integer N (x to exit): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "x")
            {
                isExit = true;
                break;
            }
            int N = 0;
            int.TryParse(answer, out N);

            if (N > 0)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Shuffle(N);
                var elapsedMs = watch.ElapsedMilliseconds;
                Console.WriteLine($"Parallel N = {N}");
                Console.WriteLine($"Time(ms): {elapsedMs}");
            }
            else
            {
                Console.WriteLine("Invalid input, enter a integer greater than 0");
            }
        }
        while (!isExit);

    }

    static void Shuffle(int N)
    {
        //  1 to N-1 array for result 
        int[] numbers = Enumerable.Range(1, N - 1).ToArray();

        // Determine chunk size for parallel processing
        int numThreads = Environment.ProcessorCount;
        int chunkSize = (N - 1) / numThreads; //how much each thread will calculate

        //shuffle using multiple threads from 0 To number of threads i is index(or thread)
        Parallel.For(0, numThreads, i =>
        {

            int start = i * chunkSize;
            int end = 0;
            if (i == numThreads - 1)
            {
                end = numbers.Length;
            }
            else
            {
                end = start + chunkSize;
            }


            // random instance for each thread
            Random localRng = new Random();

            // Fisher-Yates algorithm 
            for (int j = end - 1; j > start; j--)
            {
                int swapIndex = localRng.Next(start, j + 1);
                int temp = numbers[j];
                numbers[j] = numbers[swapIndex];
                numbers[swapIndex] = temp;
            }
        });

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}