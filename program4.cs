Given arrival and departure times of all trains that reach a railway station. Find the minimum number of platforms required
for the railway station so that no train is kept waiting.
Consider that all the trains arrive on the same day and leave on the same day. Arrival and departure time can never be the same 
for a train but we can have arrival time of one train equal to departure time of the other. At any given instance of time , same
platform can not be used for both departure,arrival of the train. in such cases, we need different platforms.
Ex-1:
Input 1: n=6
arr[] = {0900 ,0940,0950,1100,1500,1800}
dep[] = {0910,1200,1120,1130,1900,2000}
output: 3 (Minimum 3 platforms are required)

arr[] ={100,300,500}
dep[] ={900,400,600} 
op-2 platforms

using System;

public class Test
{
	public static void Main()
	{
		int ip1 = Convert.ToInt32(Console.ReadLine());
		int[] arr= Array.ConvertAll(Console.ReadLine().Split(' '),(item) => Convert.ToInt32(item));
		int[] dep= Array.ConvertAll(Console.ReadLine().Split(' '),(item) => Convert.ToInt32(item));
		int pf=1,res=1;
		for(int i=0;i<ip1;i++){
		    pf=1;
		    for(int j=0;j<ip1;j++){
		        if(i!=j){
		            if(arr[i]>=arr[j] && dep[j]>=arr[i]){
		                pf++;
		            }
		        }
		    }
		    res=Math.Max(res,pf);
		}
		Console.WriteLine(res);
	}
}
