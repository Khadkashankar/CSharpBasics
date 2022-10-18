using System;
class IterationStatement
{
    static void Main()
        {
IterationStatement y = new IterationStatement();
y.LearnForLoop();
        }
    
    void LearnForLoop() 
    {
             for(int i=0;i<=10;i++)
             {
                Console.WriteLine("i'm good");
             }
             int[] numbers ={12,3,4,54,5,2};
             foreach(int x in numbers)
             {
                if(x%2==0)
                {
                    Console.WriteLine($"{x} is even");
                }
                else{
                      Console.WriteLine($"{x} is even");

                }
             }
    }

}