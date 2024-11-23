using System.Net.Http.Headers;

namespace EspacioEmpleado;

//definimos la variable de tipo enum para guardar los cargos//
public enum Cargo
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

class Empleado{
    //definimos los campos//
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private Cargo cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargo cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNac = fechaNac;
        EstadoCivil = estadoCivil;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }

    //definimos las propiedades//
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargo Cargo { get => cargo; set => cargo = value; }
    

    //definimos los metodos//

    //metodo privado para calcular las fechas//
    private int CalcularDiferencia(DateTime FechaEvaluada){
        //usamos la fecha actual para calcular la antiguedad//
        DateTime fechaActual = DateTime.Now;
        int antiguedad = 0;
        //logica para calcular la antiguedad//
        antiguedad = fechaActual.Year - FechaEvaluada.Year;
        if(FechaEvaluada.Month > fechaActual.Month){
            antiguedad--;
        }else if(fechaActual.Month == FechaEvaluada.Month){
            if(FechaEvaluada.Day > fechaActual.Day){
                antiguedad--;
            }
        }
        return antiguedad;
    }
    public int ObtenerAntiguedad(){
        int antiguedad = CalcularDiferencia(FechaIngreso);
        return antiguedad;
    }

    public int ObtenerEdad(){
        int edad = CalcularDiferencia(FechaNac);
        return edad;
    }

    public int ObtenerRestantesJubilacion(){
        int restantes = 65 - CalcularDiferencia(FechaNac);
        return restantes;
    }

    //metodo privado para calcular el adicional//
    private double CalcularAdicional(){
        double adicional = 0;
        //adicional por la antiguedad//
        if(CalcularDiferencia(FechaIngreso) <= 20){
            adicional += (SueldoBasico / 100) * CalcularDiferencia(FechaIngreso);
        }else{
            adicional += (sueldoBasico / 100) * 25;
        }

        //adicional segun el cargo//
        if(Cargo == Cargo.Ingeniero || Cargo == Cargo.Especialista){
            adicional *= 1.5;
        }

        //adicional segun el estado civil//
        if(EstadoCivil == 'C' || estadoCivil == 'c'){
            adicional += 150000;
        }

        return adicional;
    }
    public double ObtenerSalario(){
        double adicional = CalcularAdicional();
        double salario = adicional + SueldoBasico;
        return salario;
    }


}