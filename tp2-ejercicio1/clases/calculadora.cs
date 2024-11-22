namespace EspacioCalculadora;

class Calculadora{
    
    //definimos lo/los campos//
    private double dato;

    //definimos la/las propiedades para acceder a los campos//
    public double Resultado 
    {
        get => dato;
    }

    //definimos los metodos//
    public void Sumar (double valor){
        dato += valor;
    }

    public void Restar (double valor){
        dato -= valor;
    }

    public void Multiplciar (double valor){
        dato *= valor;
    }

    public void Dividir (double valor){
        if(valor != 0){
            dato /= valor;
        }else{
            Console.WriteLine("no se puede dividir por 0");
        }
    }

    public void Limpiar(){
        dato = 0;
    }

    //metodo para encadenar operaciones//
    public void encadenarOperaciones(){
        //variable para controlar el bucle//
        bool bucle = true;
        while(bucle){
            Console.WriteLine("----------CALCULADORA----------");
            Console.WriteLine($"Valor Actual: {this.Resultado}");
            Console.WriteLine("1: Sumar");
            Console.WriteLine("2: Restar");
            Console.WriteLine("3: Multiplicar");
            Console.WriteLine("4: Dividir");
            Console.WriteLine("5: Limpiar");
            Console.WriteLine("6: Salir");
            Console.WriteLine("eliga una operacion:");
            string elegirOperacionCadena = Console.ReadLine();
            int operacion = 0;
            bool resultadoConversion = int.TryParse(elegirOperacionCadena, out operacion);
            if(resultadoConversion && operacion >= 1 && operacion <= 4){
                //pedimos el numero al usuario//
                Console.WriteLine("ingrese un numero");
                string numeroCadena = Console.ReadLine();
                double numero = 0; 
                bool resultadoConversionNumero = double.TryParse(numeroCadena, out numero);
                if(resultadoConversionNumero){
                    //decidimos que operacion aplicar utilizando la estructura de control de flujo switch//
                    switch(operacion){
                        case 1:
                            this.Sumar(numero);
                        break;

                        case 2:
                            this.Restar(numero);
                        break;

                        case 3:
                            this.Multiplciar(numero);
                        break;

                        case 4:
                            this.Dividir(numero);
                        break;
                    }
                }else{
                    Console.WriteLine("No se ingreso un numero");
                }
            }else if(resultadoConversion && operacion == 5){
                this.Limpiar();
            }else if(operacion == 6){
                Console.WriteLine("Saliendo...");
                bucle = false;
            }else{
                Console.WriteLine("No se indico una opcion valida");
            }
        }
    }
}