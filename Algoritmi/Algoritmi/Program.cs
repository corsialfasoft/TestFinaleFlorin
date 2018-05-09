using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmi {
	class Program {
		static void Main(string[] args) {
			Es1();
		}
		public static void Es1(){
			int count = 0;
			int i;
			for(i = 0;count<15;i++){
				if(i%2==0){
					Console.WriteLine("{0}  ==> {1}",count,i);
					count++;
				}
			}
			--i;
			Console.WriteLine("_____ORA ARRIVANO I NR DISPARI_____");
			for (;count>0;i--){
				if(i%2!=0){
					Console.WriteLine("{0}  ==> {1}",count,i);
					count--;
				}
			}
		}
	}
}
