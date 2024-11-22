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

class empleado{
    //definimos los campos//
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private double sueldoBasico;
    private Cargo cargo;

    //definimos las propiedades//
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargo Cargo { get => cargo; set => cargo = value; }

    

}