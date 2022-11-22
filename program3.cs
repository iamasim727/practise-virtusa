Replace every character with a next 3rd character in the string
inp1: abcd
oup1: defg

inp2:xza
oup2:acd

using System;
public class Test
{
	public static void Main()
	{
	  string input1 = Console.ReadLine();
	  string n="";
	  for(int i=0;i<input1.Length;i++){
	      n+="3";
	  }
	  string t = "";
      for (int i = 0;i<input1.Length; i++) {
      int a =(int)(input1[i] - '0');
      int b =(int)(n[i]+a);
      if (b > 122)
        b -= 26;
      char x = (char)b;
      t +=x;
    }
    Console.WriteLine(t);
	}
}
