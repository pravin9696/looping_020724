namespace looping_020724
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //int a=1000,b=200,c=300;
            //if(a > b && a > c)
            //{
            //    Console.WriteLine(a);
            //}
            // else if (b > c)
            //    {
            //     Console.WriteLine(b);
            //     }
            //     else
            //      {
            //      Console.WriteLine(c);
            //      }
            //Console.WriteLine("this is last statement..");
            #endregion
            #region palindrom withoud loop
            //int no = 123;  //123
            //int temp = no;
            //int digit1 = no % 10;//3
            //no = no / 10;  //12

            //int digit2 = no % 10;//2
            //no = no / 10; // 1

            //int digit3 = no % 10;//1
            //no = no / 10;//0

            //int sum = digit1 * 100 + digit2 * 10 + digit3 * 1;
            //Console.WriteLine(sum);


            //if (temp == sum)
            //{
            //    Console.WriteLine("palindrom");
            //}
            //else
            //{
            //    Console.WriteLine("Not palindrom");
            //}
            #endregion

           // int no = 11;
            //while (no < 10) 
            //{
            //    Console.WriteLine("inside while loop");
            //    Console.WriteLine(no);
            //    no++;//no=no+1;
            //}

            int no = 11;
            do
            {
              
                Console.WriteLine(no);
                no++;//no=no+1;
            } while (no < 10);
            Console.WriteLine("this is last statement...");
        }
    }
}
