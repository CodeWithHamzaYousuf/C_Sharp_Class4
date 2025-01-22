namespace result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Enter Your Percentage");
            //int Stdper = Convert.ToInt32 (Console.ReadLine());
            //if(Stdper > 80)
            //{
            //    Console.WriteLine("Your Grade Is A+");
            //}
            //else if(Stdper > 70 && Stdper < 80)
            //{
            //    Console.WriteLine("Your Grade Is A");
            //}
            //else if (Stdper > 60 && Stdper < 70)
            //{
            //    Console.WriteLine("Your Grade Is B");
            //}
            //else if (Stdper > 40 && Stdper < 60)
            //{
            //    Console.WriteLine("Your Grade Is C");
            //}
            //else if (Stdper < 40)
            //{
            //    Console.WriteLine("Your Grade Is D");
            //}
            //==================================================//
            //int input = Convert.ToInt32(Console.ReadLine());

            //int input = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //while (1 <= 10)
            //{
            //    int result = input * i;
            //    Console.WriteLine(input + "*" + i + "=" + result);
            //    i++;



            //========CLASS 2========//
            //int[] numbers = new[] { 25, 32, 65, 45, 12 };
            //int i = 0;
            //while (i < numbers.Length)
            //{
            //    Console.WriteLine(numbers[i]);
            //    i++;
            ////}
            //do
            //{
            //    Console.WriteLine(numbers[i]);
            //    i++;
            //}
            //while (i < numbers.Length);


            int[,] marks = new int[3, 4] {

                { 11, 21, 34, 21 },
                { 53, 65, 47, 84 },
                { 95, 10, 61, 82 }

            };
            //foreach (var item in marks)
            //{
            //    Console.WriteLine(item);

            //}
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int c = 0; c < marks.GetLength(1); c++)
                {
                    Console.WriteLine(marks[i, c]);
                }
                Console.WriteLine();
            }
        }
    }


