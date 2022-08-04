using System;
					
public class Program
{
	static void quickpick(int noofgames){
		Console.WriteLine("No of games are : "+ noofgames);
		Random rand = new Random();
		int[,] array2D = new int[noofgames,7];
		for ( int i = 1 ; i <= noofgames; i++)
		{
			for ( int j = 1 ; j <= 7; j++)
			{
				int number = rand.Next(1, 47);
				array2D[i-1,j-1] = number;
			}
		}
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
						Console.WriteLine("OOPS looks like 2 tickets have the same number, please run again");
						quickpick(noofgames);
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