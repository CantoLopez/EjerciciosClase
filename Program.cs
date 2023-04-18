
Console.WriteLine("Elija su ejercico \n1) Ejercicio 1 \n2) Ejercico 2 \n3) Ejercico 3" );
int op = Convert.ToInt32(Console.ReadLine());
switch (op)
{
    case 1:
        Console.Write("Ejercicio 1");
        //Variables
        int mes;

        Console.WriteLine("\nIngrese un numero del 1 al 12");
        mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("Mes de ENERO");
                break;
            case 2:
                Console.WriteLine("Mes de FEBREO");
                break;
            case 3:
                Console.WriteLine("Mes de MARZO");
                break;
            case 4:
                Console.WriteLine("Mes de ABRIL");
                break;
            case 5:
                Console.WriteLine("Mes de MAYO");
                break;
            case 6:
                Console.WriteLine("Mes de JUNIO");
                break;
            case 7:
                Console.WriteLine("Mes de JULIO");
                break;
            case 8:
                Console.WriteLine("Mes de AGOSTO");
                break;
            case 9:
                Console.WriteLine("Mes de SEPTIEMBRE");
                break;
            case 10:
                Console.WriteLine("Mes de OCTUBRE");
                break;
            case 11:
                Console.WriteLine("Mes de NOVIEMBRE");
                break;
            case 12:
                Console.WriteLine("Mes de DICIEMBRE");
                break;
            default:
                Console.WriteLine("ERROR DEL SISTEMA");
                break;

        }
        break;
    case 2:
        Console.WriteLine("Ejercico No. 2");
        Console.WriteLine("Por favor ingrese un numero ");
        int valor = Convert.ToInt32(Console.ReadLine());
        int a = valor % 2 ;
        if (a == 0)
        {
            Console.WriteLine($"El valor ingresado: {valor} es entero ");
        }
        else
        {
            Console.WriteLine($"El valor ingreasado: {valor} no es entero");
        }
        break;

    case 3:
        Console.WriteLine("Ejercicio No.3");
        Console.WriteLine("Ingrese las horas que estuvo el cliente: -> ");
        int horas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese los minutos que estubo el cliente: -> ");
        int min = Convert.ToInt32(Console.ReadLine());

        if((horas < 1 && min <= 60) || (horas <= 1 && min <0))
        {
            Console.WriteLine("Su pago es de 5$");
        }
        else if ((horas > 1 && horas <= 2) || (horas == 1 && min < 60 )){
            Console.WriteLine("Su pago es de 15$");
        }
        else
        {
            Console.WriteLine("El pago es de 40$");
        }
        break;

    default : 
        Console.WriteLine("Error del sistema");
        break;
        
}



