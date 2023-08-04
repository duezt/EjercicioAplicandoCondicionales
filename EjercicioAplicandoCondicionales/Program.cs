


//Primer Ejercicio
Calculadora();

//Segundo Ejercicio
TresCifras(); 

//Tercer Ejercicio
ResultadoDeTest();


void Calculadora()
{
    double firstValue;
    double secondValue;
    string? userData = string.Empty;

    Console.WriteLine("-*Calculadora*-");
    Console.WriteLine($"Favor introducir el primer valor");
    userData = Console.ReadLine();
    if (double.TryParse(userData, out firstValue))
    {
        Console.WriteLine($"Favor introducir el segundo valor");
        userData = Console.ReadLine();
        if (double.TryParse(userData, out secondValue))
        {
            if (firstValue > secondValue)
            {
                Console.WriteLine($"La suma de {firstValue} y {secondValue} es: {firstValue + secondValue}");
                Console.WriteLine($"La diferencia de {firstValue} y {secondValue} es: {firstValue - secondValue}");

            }
            else
            {
                Console.WriteLine($"El producto de {firstValue} X {secondValue} es: {firstValue * secondValue}");
                Console.WriteLine($"La division de {firstValue} / {secondValue} es: {firstValue / secondValue}");
            }
        }
        else
        {
            Console.WriteLine($"El valor introducido \"{userData}\" del segundo valor es invalido, vuelva a intentarlo");
        }


    }
    else
    {
        Console.WriteLine($"El valor introducido \"{userData}\" del segundo valor es invalido");
    }



}


void TresCifras()
{
    int value;
    string? userData = string.Empty;

    Console.WriteLine("Introducir un número entero positivo de hasta tres cifras");
    userData = Console.ReadLine();  
    if (int.TryParse(userData, out value))
    {
        switch (value)
        {
            case >= 1000:
                Console.WriteLine($"ERROR: El numero introducido: {value} tiene tres cifras");
                break;
            case >= 100 and < 999:
                Console.WriteLine($"El numero introducido: {value} tiene tres cifras");
                break;
            case < 99 and >= 10:
                Console.WriteLine($"El numero introducido: {value} tiene menos de dos cifras");
                break;
            case < 10 and > 0:
                Console.WriteLine($"El numero introducido: {value} es de una cifra");
                break;
            case < 0:
                Console.WriteLine("Favor introducir un numero que sea positivo");
                break;
        }
    }
    else
    {
        Console.WriteLine($"El valor introducido \"{userData}\" no es un numero entero");
    }
}


void ResultadoDeTest()
{
    //Variables
    double questions;
    double answers;
    string? userData = string.Empty;
    double porcentage;

    Console.WriteLine("Cuantas preguntas tenia su test?");
    userData = Console.ReadLine();
    if (!double.TryParse(userData,out questions))
    {
      Console.WriteLine($"El valor introducido debe ser numerico no \"{userData}\" ");
    }
    else
    {
        Console.WriteLine("Cuantas preguntas respondio bien?");
        userData = Console.ReadLine();
        if (!double.TryParse(userData, out answers))
        {
            Console.WriteLine($"El valor introducido debe ser numerico no \"{userData}\" ");
        }
        else
        {
            porcentage = (answers/ questions) *100;
            Console.WriteLine(porcentage);

            switch (porcentage)
            {
                case < 50:
                    Console.WriteLine($"Fuera de nivel, su porcentaje fue {porcentage}%");
                    break;
                case >= 50 and < 75:
                    Console.WriteLine($"Nivel regular, su porcentaje fue {porcentage}%");
                    break;
                case >= 75 and < 90:
                    Console.WriteLine($"Nivel Medio, su porcentaje fue {porcentage}%");
                    break;
                default:
                    Console.WriteLine($"Nivel Medio, su porcentaje fue {porcentage}%");
                        break;
            }
        }
    }
}



