import java.io.*;
import java.util.*;

class fibonacci{
	
	static void printFibSequence(int n){
		int[] fibArr = new int [n+1];
		
		fibArr[0] = 0;
		fibArr[1] = 1;
		
		System.out.print(fibArr[0] + " " + fibArr[1] + " ");
		
		for(int i=2; i<n; i++){
			fibArr[i] = (fibArr[i-1] + fibArr[i-2]);
			System.out.print(fibArr[i] + " ");
		}
	}
	
	public static void main(String[] args){
		System.out.print("Enter the number of terms to be displayed: ");
		
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		
		printFibSequence(n);
	}
	
}