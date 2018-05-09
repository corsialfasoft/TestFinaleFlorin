using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models {
	public class DomainModel {
		public void AddMenu(Menu menu){
			
		}
		public List<Menu> CercaMenu(string cerca){
			Menu men1 = new Menu();
			men1.id=1;
			men1.Nome="DDD";
			men1.PrOCen="Pranzo";
			men1.Data="Domenica";
			Primo p1= new Primo();
			p1.nome="Fagioli";
			p1.costo=13;
			men1.primi.Add(p1);
			Secondo s1= new Secondo();
			s1.nome="Bisteccona";
			s1.costo=23;
			men1.secondi.Add(s1);
			Menu men2 = new Menu();
			men2.id=2;
			men2.Nome="GGG";
			men2.PrOCen="Cena";
			men2.Data="Domenica";
			Primo p2= new Primo();
			p2.nome="Pasta";
			p2.costo=15;
			men2.primi.Add(p2);
			Secondo s2= new Secondo();
			s2.nome="Agnello";
			s2.costo=23;
			men2.secondi.Add(s2);

			List<Menu> result = new List<Menu>();
			result.Add(men1);
			result.Add(men2);
			return result;
		}
		public Menu VediMenu(int id){
			Menu men1 = new Menu();
			men1.id=1;
			men1.Nome="DDD";
			men1.PrOCen="Pranzo";
			men1.Data="Domenica";
			Primo p1= new Primo();
			p1.nome="Fagioli";
			p1.costo=13;
			men1.primi.Add(p1);
			Secondo s1= new Secondo();
			s1.nome="Bisteccona";
			s1.costo=23;
			men1.secondi.Add(s1);
			return men1;
		}
	}
	public class Menu{
		public int id{get;set;}
		public string Nome{get;set;}
		public string Data{get;set;}
		public string PrOCen{get;set;}
		public List<Primo> primi;
		public List<Secondo> secondi;
		public Menu(){
			primi= new List<Primo>();
			secondi=new List<Secondo>();
		}
	}

	public class Secondo {
		public string nome{get;set;}
		public int costo{get;set;}
	}

	public class Primo {
		public string nome{get;set;}
		public int costo{get;set;}
	}
}