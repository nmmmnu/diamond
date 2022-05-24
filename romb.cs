using System;

public class Program
{
	public static void Main()
	{
		const int a = 54;

		string[] m = new string[4]{ "░", "▒", "▓", "█"};
		string[] k = new string[4]{ "▓", "█", "░", "▒"};

		for (int i=1; i <= a; i++){
			int x = i % 4;

			for (int j=1; j <= a - i; j++)
				Console.Write(" ");

			for (int j=1; j <= i; j++){
				Console.Write( m[x] + k[x] );
			}

			Console.WriteLine();
		}

		for (int i=a-1; i >= 1; i--){
			int x = i % 4;

			for (int j=1; j <= a - i; j++)
				Console.Write(" ");

			for (int j=1; j <= i; j++){
				Console.Write( m[x] + k[x] );
			}

			Console.WriteLine();
		}
	}
}


