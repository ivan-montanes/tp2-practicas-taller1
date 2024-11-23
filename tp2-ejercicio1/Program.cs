using EspacioEmpleado;
Empleado empleado1 = new Empleado("ivan","montañes",new DateTime(2005,1,27),'s',new DateTime(2021,5,5),870000,Cargo.Investigador);
Empleado empleado2 = new Empleado("santiago","gonzales",new DateTime(2004,2,14),'s',new DateTime(2019,3,8),1350000,Cargo.Ingeniero);
Empleado empleado3 = new Empleado("mateo","leiva",new DateTime(2003,2,13),'s',new DateTime(2023,5,10),675000,Cargo.Auxiliar);
Empleado[] empleados = [empleado1, empleado2, empleado3];
//obtenemos lo que se paga de salarios, y el empleado mas cercano a jubilarse//
double gastoTotal = 0.0;
Empleado masCercano = null;
int restantes = 100000000;
foreach(Empleado empleado in empleados){
    gastoTotal += empleado.ObtenerSalario();
    if(empleado.ObtenerRestantesJubilacion() < restantes){
        restantes = empleado.ObtenerRestantesJubilacion();
        masCercano = empleado;
    }
}
Console.WriteLine($"Total Pagado En Concepto De Salarios ${gastoTotal}");
Console.WriteLine("----------EMPLEADO MAS CERCANO A JUBILARSE----------");
Console.WriteLine($"Nombre Completo: {masCercano.Nombre} {masCercano.Apellido}");
Console.WriteLine($"Edad: {masCercano.ObtenerEdad()}");
Console.WriteLine($"Cantidad de años para jubilarse: {masCercano.ObtenerRestantesJubilacion()}");
Console.WriteLine($"Salario Correspondiente {masCercano.ObtenerSalario()}");
