using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Algoritmi {
	class Program {
		static void Main(string[] args) {
			//Es1();
			int res = Es2("Nel del cammin  della mia vita mi  ritrovai a far codice su .NET" ,"mezzo");
			Console.WriteLine("Occorrenze = {0}",res);
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
		public static int Es2(string testo , string cerca){
			string [] test = testo.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',',' ' });
			var result = from parola in test where parola.ToLowerInvariant()==cerca.ToLowerInvariant()
							select parola;
			int risultato = result.Count();
			Console.WriteLine("La Parola {0} è presente {1} volte",cerca,risultato);
			return risultato;
		}
	}
}
