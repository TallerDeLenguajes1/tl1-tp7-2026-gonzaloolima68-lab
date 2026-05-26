using EspacioCalculadora;

string? opcion ;

Calculadora calculadora1=new Calculadora();
do
{
    Console.WriteLine("1=Sumar -- 2 = Restar -- 3 = Multiplicar -- 4 = Dividir -- 0=finalizar"); 
    string opcion=Console.ReadLine();

    if(opcion!="0"){
        Console.WriteLine("ingrese el los dos numeros");

        if(double.TryParseryParse(Console.ReadLine(),out double numero1) && double.TryParse(Console.ReadLine(),out double numero2)){
            calculadora1.setdato(numero1);
            switch (opcion)
        {
            case "1": 
                    calculadora1.suma(numero2);
                    Console.WriteLine("suma ="+calculadora1.getdato());
            break;
            case "2": 
                    calculadora1.resta(numero2);
                    Console.WriteLine("resta ="+calculadora1.getdato());
            break;
            case "3": 
                    calculadora1.multiplicar(numero2);
                    Console.WriteLine("multiplicacion ="+calculadora1.getdato());
            break;
            case "4": 
                    calculadora1.dividir(numero2);
                    Console.WriteLine("division ="+calculadora1.getdato());
            break;
            default:
                    opcion="0";
            break;
        }
        }else{
        opcion="0";
    }
        
    }else{
        opcion="0";
    }
} while (opcion!= "0");





Console.WriteLine("suma ="+calculadora1.getdato());