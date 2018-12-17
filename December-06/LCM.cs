using System;

class LCM{
	public int FindLCM(int a, int b) {
		Console.WriteLine("2) a: {0}  b: {1}\n", a, b);
		if ( a == b ){
			return a;
		}
		
		else if ( a > b ) {
			int aCount = 2, bCount = 1, tempa = a, tempb = b;
			while(true){
				if(tempa > tempb) {
					tempb =  b * bCount;
					Display(tempa, tempb);
					bCount++;
					continue;
				}
				else if(tempa == tempb) {
					Display(tempa, tempb);
					return tempb;
				}
				else if(tempa < tempb) {
					tempa = a * aCount;
					Display(tempa, tempb);
					aCount++;
					continue;
				}
			}
			return 0;
		}
		
		else {
			int aCount = 1, bCount = 2, tempa = a, tempb = b;
			while(true){
				if(tempa < tempb) {
					tempa = a * aCount;
					Display(tempa, tempb);
					aCount++;
					continue;
				}
				else if(tempa == tempb) {
					Display(tempa, tempb);
					return tempb;
				}
				else if(tempa > tempb) {
					tempb =  b * bCount;
					Display(tempa, tempb);
					bCount++;
					continue;
				}
			}
			return 0;
		}
	}
	
	public void Display(int a, int b){
		Console.WriteLine("tempa   tempb");
		Console.WriteLine(" {0}     {1}", a, b);
	}
}

class MainClass {
	static public void Main(String[] args) {
		int a, b;
		
		Console.WriteLine("Enter the no. to determine the LCM: ");
		
		Console.Write("a: ");
		a = Int32.Parse(Console.ReadLine());
		Console.Write("b: ");
		b = Int32.Parse(Console.ReadLine());
		
		Console.Write("a: {0}  b: {1}\n", a, b);
		
		LCM obj = new LCM();
		int lcm = obj.FindLCM(a, b);
		
		Console.WriteLine("\nLCM of {0} and {1} = {2}\n", a, b, lcm);
		
		
		Console.ReadKey();
	}
}
