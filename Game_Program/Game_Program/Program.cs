namespace Game_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of robbers: ");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the robber with whon sam will start shooting: ");
            int Start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the gap between robbers: ");
            int gap = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[R];
            int arr1 = Start - 1;
            int ShotsCompleted = 0;

            for (int i = 0; i < R; i++)
            {
                arr[i] = i + 1;

            }
            while (R != 0)
            {
                if (arr1 >= R)
                {
                    arr1 = arr1 % R;
                }
                Console.WriteLine($"Target = {arr[arr1]} , {++ShotsCompleted} shots completed");

                for (int i = arr1; i < R - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                R--;
                arr1 += gap;
            }
            Console.WriteLine(ShotsCompleted + " shots taken");


        }


    }
 }








