using System;
 

namespace hackrank_Exceptions___String_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
             string S = Console.ReadLine();
            //  bool result=checkNumber(S);

            //  if(result==false)
            //  Console.WriteLine("Bad String");
            try
            {
                 if (!Int32.TryParse(S, out int sayi))
                {
                Console.WriteLine(int.Parse(S));
                }

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Bad String"+ ex);
                
            }
             
               
        
        }
    }
}
