using System;
					
public class Program
{
	public static void Main(int[] args)
	{
		int[] arr = new int[] {41, 65, 14, 55, 30, 64, 34};
		Array.Sort(arr);
		Array.Reverse(arr);
		Console.WriteLine(arr[0]);
	}
}
