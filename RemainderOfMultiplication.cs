// You are given an array consisting of n integers. You must find the reminder of ((arr[0] * arr[1] * arr[2] * ... * arr[n - 1]) / k)
// https://app.glider.ai/practice/problem/algorithms/find-reminder/problem#test-case-tab-1
// https://www.geeksforgeeks.org/find-reminder-of-array-multiplication-divided-by-n/
using System; 
using System.Linq;
public class Test 
{ 
   public static void Main(string[] args) 
   { 
       var a = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
       var numbers = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
        
       int k = a[1];
       int res = 1;
       
       foreach(int i in numbers)
       {
            res = res * (i % k);
       }
       
        Console.WriteLine(res % k);
   } 
}