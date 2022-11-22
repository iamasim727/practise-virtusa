Nth character in decrepted string:
Every character in the input string is followed by its frequency.
Write a function to decrypt the string and find the n0' character of the decrypted string.
If no character exsists at the position then return "-1". For eg- if the input 
striing is "a2b3" the decrypted string is "aaabb"
i/p:
input1: a string
input 2: n , the position of the character starting from 1
O/p:
Nth position character else -1

ex1:
ip1=a1b1c3
ip2=5
o/p=c 

ex2:
ip1=a3b2
ip2=7
o/p=-1

using System;
public class Test
{
	public static void Main()
	{
	  string input1 = Console.ReadLine();
      int input2 = Convert.ToInt32(Console.ReadLine());
      String expand = "";
      String str= "";
      int f= 0;
      for(int i=0;i<input1.Length;)
        {
            str="";
            f=0; 
            while (i<input1.Length && input1[i]>='a'&& input1[i]<='z')
            {
                str+=input1[i];
                i++;
            }
            while(i<input1.Length && input1[i] >='1'&& input1[i]<='9')
            {
                f=f*10+input1[i]-'0';
                i++;
            }
            for (int j=1;j<=f;j++){
                expand += str;
            }
        }
        if(f==0)
            expand+= str;
        if(input2>expand.Length)
            Console.WriteLine("-1");
        else
            Console.WriteLine(expand[input2 - 1]);
	}
}
