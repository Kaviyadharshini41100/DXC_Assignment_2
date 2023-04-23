namespace Game_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Enter no of Robbers:");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Robber with whom Sam will start shooting:");
                int j = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the gap between the robbers:");
                int G = Convert.ToInt32(Console.ReadLine());
                int m = j; //m=current robber
                int n = 0; //n=shoots completed
                while (i > 0)
                {
                    Console.WriteLine("Target = " + m + ", " + n + " shots completed");
                    n++;
                    i--;
                    m = (m + G) % (i + 1);
                    if (m == 0)
                    {
                        m = i;
                    }
                }
                Console.WriteLine(n+ " Shots taken...");
            }
        }

 }
