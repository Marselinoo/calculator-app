class calculator
(
	static void main (string [] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("hasil penambahan: {0} + (1) = (2)", a, b, penambahan(a, b));
		Console.WrietLine ("hasil pengurangan (1) - (1) = (2)", a, b, pengurangan (a,b))
		Console.WrietLine ("hasil perkalian (1) - (1) = (2)", a, b, perkalian (a,b))
		Console.WrietLine ("hasil prmbagian (1) - (1) = (2)", a, b, pembagian (a,b))
		
		Console.ReadKey();
	}	
	
	static int penambahan (int a, int b)
	{
		return a - b;
	}
	static int pengurangan (int a, int b)
	{
		return a + b;
	}



)