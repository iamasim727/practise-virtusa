Question:
Minimum operations required to return to main folder
John is working on a complex project. The main project directory 
has many nested directories. I.e directory inside a directory.Duw to the complexity
has to change the directory every time he has to work on a different modules.
Sometimes he does not remember in which directory he is working and how
to go back to the main directory.-root directory

Write a program which would find the minimum steps required to go 
back to the main directory from the current directory given the sequence of
operations performed by join after entering the root directory.
Jon can perform the following operations:
1."../": Moves to the parent folder of the current folder. 
(If current folder is the main it stays in the same folder)
2."./":Remains in the same folder.
3."F/": Moves to the child folder named F.

Input 1- 6
Input 2- arr[] = {"F1/","F2/","./","F3/","../","F31/"}
Output - 3

using System;

public class Test
{
	public static void Main()
	{
	    int n = Convert.ToInt32(Console.ReadLine());
		String line = Console.ReadLine();
		string[] a =line.Split(',');
		int count=0;
		for(int i=0;i<n;i++){
		    if(a[i]=="./"){
		        count=count + 0;
		    }
		    else if(a[i]=="../"){
		        count=count-1;
		    }
		    else{
		        count=count+1;
		    }
		}
		Console.WriteLine(count);
	}
}
