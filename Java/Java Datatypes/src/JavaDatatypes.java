import java.io.*;
import java.util.*;

public class JavaDatatypes {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int number=input.nextInt();

        for(int i=0;i<number;i++)
        {

            try
            {
                long x=input.nextLong();
                System.out.println(x+" can be fitted in:");
                if(x>=-128 && x<=127)System.out.println("* byte");

                if(x>=-32768 && x<=32767)System.out.println("* short");

                if(x>=-Math.pow(2,31) && x<=(Math.pow(2,31)-1))
                    System.out.println("* int");

                if(x>=-Math.pow(2,63) && x<=(Math.pow(2,63)-1))
                    System.out.println("* long");
                //Complete the code
            }
            catch(Exception e)
            {
                System.out.println(input.next()+" can't be fitted anywhere.");
            }

        }
    }
}
