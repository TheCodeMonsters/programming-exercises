using System;

public class Persona{

		public String Name {get; set;}
		public String LastName {get; set;}
		public String Direction {get; set;}
		public String Phone {get; set;}
		public Int16 Age {get; set;}
			
}


public class Programador : Persona {	
	public String Jobs {get; set;}
	
}


class Program {
	public static void Main(string[] args) {
		
		Persona p1 = new Persona();
		p1.Name = "Juan";
		p1.LastName = "Perez";
		p1.Direction = "Calle 123";
		p1.Phone = "123456789";
		
		p1.Age = 23;
		Persona p2 = new Persona();
		p2.Name = "Pedro";
		p2.LastName = "Perez";
		p2.Direction = "Calle 123";
		p2.Phone = "123456789";
		p2.Age = 23;
		
		Persona p3 = new Persona();
		p3.Name = "Juan";
		p3.LastName = "Perez";
		p3.Direction = "Calle 123";

	}

}
