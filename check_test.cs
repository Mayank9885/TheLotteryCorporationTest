using System;
					
public class Program
{
	static void quickpick(int noofgames){
		Console.WriteLine("No of games are : "+ noofgames);
		Random rand = new Random();
		int[,] array2D = new int[4,7]{{1,1,1,1,1,1,1},{1,2,1,1,1,1,1},{1,1,3,1,1,1,1},{1,1,4,1,1,1,1}};
		int m = 1;
		for (int k = 0; k < noofgames; k++)
        {	
			Console.Write("Game "+m+" : ");
            for (int l = 0; l < 7; l++)
            {
                Console.Write(array2D[k,l]+ "\t");
            }
		 	m++;
            Console.WriteLine();
        }
		for (int i = 0; i < noofgames - 1; i++)
        {
			for (int j = i+1; j < noofgames; j++)
        	{
            	for (int k = 0; k < 7; k++)
            	{
                	if (array2D[i,k] == array2D[j,k])
					{
						if (k == 6){
						Console.WriteLine("OOPS looks like 2 tickets have the same number, running again");
						Environment.Exit(0);
						}
					} else {
						break;
						}
					}
            	}
			}
        }
	public static void Main()
	{
		Console.WriteLine("enter no of games");
		int noofgames = Convert.ToInt32(Console.ReadLine());
		if (noofgames < 4 || noofgames > 50) 
		{
			Console.WriteLine("no of games can only be in between 4 and 50");
			Environment.Exit(0);
		}
		quickpick(noofgames);
	}
}