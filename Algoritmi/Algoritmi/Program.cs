using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Algoritmi {
	class Program {
		static void Main(string[] args) {
			//Es1();
			//Es2("Nel del mi cammin della vita mia vita mi ritrovai mi a far codice sulla Luna ");
			List<int> vs = new List<int>();
			vs.Add(5);
			vs.Add(4);
			vs.Add(2);
			vs.Add(3);
			vs.Add(1);
			List<int> vs2 = new List<int>();
			vs2.Add(5);
			vs2.Add(4);
			vs2.Add(2);
			vs2.Add(3);
			vs2.Add(1);
			Es3(vs,vs2);
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
		public static void Es2(string testo ){
			string [] test = testo.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', } ,StringSplitOptions.RemoveEmptyEntries);
			//string cerca = test[index];
			List<string> tester = new List<string>();
			foreach(string cerca in test){
				if(!tester.Contains(cerca)){
					tester.Add(cerca);
					var result = from parola in test where parola.ToLowerInvariant()==cerca.ToLowerInvariant()
									select parola;
					int risultato = result.Count();
					Console.WriteLine("La Parola ' {0} ' è presente {1} volte",cerca,risultato);
				}
			}
		}
		public static void Es3(List<int> a , List<int>b ){
			
			foreach(int d in a ){
				Console.WriteLine(d);
			}
			Console.WriteLine();
			foreach(int tr in b){
				a.Add(tr);
			}
			Sort(a);
			
			
			foreach(int t in a ){
				Console.WriteLine(t);
			}
		}
		public static void Sort(List<int> a){
			int tester = 0;
			int min ;
			for(int i=0; i<a.Count;i++){
				min=i;
				for(int j = i+1; j<a.Count;j++){
					if(a[j]<a[min]){
						min=j;
					}
				}
				tester= a[min];
				a[min]=a[i];
				a[i]=tester;
			}
		}
	}
}
