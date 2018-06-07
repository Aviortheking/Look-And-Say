using System;
using System.Collections.Generic;

namespace ConsoleApp1 {
	class Program {

		static List<int> list1 = new List<int>();
		static List<int> listTemp = new List<int>();
		static List<int> list2 = new List<int>();
		static int num = 1;

		static String folder = @"C:\tmp\";

		static void Main(string[] args) {
			list2.Add(1);
			System.IO.File.WriteAllText(folder + num + ".txt", 1 + "");
			Console.Write("Working...");
			run();

		}

		/*
		 * Cut list1 into multiple parts(each 10 elemnts)
		 */

		static void run() {
			int b = 0; //nombre précédent
			int r = 1;  //nombre de répétition
			foreach(char n in System.IO.File.ReadAllText(folder + num++ + ".txt").ToCharArray()) {
				int t = int.Parse(n.ToString());
				if(b == t) r++;
				else {
					if(b != 0) add(b, r);
					b = t;
					r = 1;
				}

			}

			/*while(list1.Count > 0) {
				int n = list1[0];
				if(b == n) r++;
				else {
					if(b != 0) add(b, r);
					b = n;
					r = 1;
				}
				list1.Remove(n);
			}*/
			add(b, r);
			Console.WriteLine("Numbers : " + num);
			//System.IO.File.WriteAllText(@"F:\tmp\" + num + ".txt", string.Join("", list2.ToArray()));
			run();
		}
		
		static void add(int b, int r) {
			if(r != 0) System.IO.File.AppendAllText(folder + num + ".txt", r+""); //list2.Add(r);
			System.IO.File.AppendAllText(folder + num + ".txt", r+""); //list2.Add(b);
		}

	}
}