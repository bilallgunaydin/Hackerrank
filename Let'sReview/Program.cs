using System;
using System.Collections.Generic;
using System.IO;


namespace hackrank_Let_sReview
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int number=int.Parse(Console.ReadLine());
           string [] word=new string[number];
           for (int i = 0; i < number; i++)
           {
               word[i]=Console.ReadLine();
           }
          string[] newword= LetsRevieew(word,number);
           foreach (var item in newword)
           {
               Console.WriteLine(item);
           }
           
           
          

        
           

        }
        static string[] LetsRevieew(string[] value, int number)
        {
           string firstword=string.Empty;
           string secondword=string.Empty;
           string word;
           string [] newword=new string[number];
         
           for (int i = 0; i < value.Length; i++)
           {
               word=value[i];
               for (int j = 0; j < value[i].Length; j++)
               {
                  
               if(j%2==0)
                firstword=firstword+word[j];
               else
                 secondword=secondword+word[j];
               }

               newword[i]=firstword+" "+secondword;
               firstword=string.Empty;
               secondword=string.Empty;
               word=string.Empty;

           }

           return newword;
        }

        static string FullTrim(string value) 
	        {
             int index=0;
            string fullTrimmed = string.Empty;
            int spaceCounter = 0;
            while (index < value.Length) 
            {
                  if (value[index] != ' ')
                   {
                     if (spaceCounter > 0)
                        {
                              spaceCounter = 0;
                            
                            if (fullTrimmed.Length > 0)
                            {
                                 fullTrimmed = fullTrimmed + ' ';
                            }
                        }

                     fullTrimmed = fullTrimmed + value[index];
                    

                    }
                   else
                   { 
                     spaceCounter++; 
                   
                   }
                    index++; 
            }
                return fullTrimmed;
            }
    }
}
