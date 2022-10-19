// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Programes de proves");

// int a = 1;

// switch (a){
//     case 2:
//         Console.WriteLine("1");
//         break;
//     case 5:
//         Console.WriteLine("2");
//         break;
//     default:
//         Console.WriteLine(a);
//         break;
// }

// Console.WriteLine ("Hola, com et dius?");
// string nom = Console.ReadLine();
// Console.WriteLine ("Molt de gust " + nom + "!");
// Console.WriteLine ($"Molt de gust {nom}!");

// int a = 2;
// int b = 5;

// Console.WriteLine($"Suma: {(a+b)}");
// Console.WriteLine("Resta: "+(b-a));
// Console.WriteLine(a*b);
// Console.WriteLine(b/a);

int control = 0; //declaració de la primera variable de control de flux
int num1 = 0; // variable de primer número
int num2 = 0; // variable de segon número

do{ //inicia un do while mentres control sigui inferior a 2 per a tota la app
     do{  //inicia la petició de numeros
     
        Console.Write("Introdueix un numero: ");
        try {
            num1 = int.Parse(Console.ReadLine());
            control++;
        }catch{
            Console.WriteLine("Introdueix un número valid!");
        } //demana introduir un número per consola i comprova que és pugui fer servir com a int, sinó retorna un error i torna a demanar el número
    }while(control == 0);//manté la petició fins que és correcte l'entrada
    do{
        Console.Write("Intodueix un segón número: ");
        try {
            num2 = int.Parse(Console.ReadLine());
            control++;
        }catch{
            Console.WriteLine("Introdueix un número valid!"); 
        }//demana introduir un número per consola i comprova que és pugui fer servir com a int, sinó retorna un error i torna a demanar el número
    }while(control==1);//manté la petició fins que és correcte l'entrada
    
    int control2 = 0; //declaració de la segona variable de control de flux

    do{  //sol·licita la operació a fer amb les dades entrades, també dona la opció de sortir una vegada ha respost alguna cosa no permesa com a operació      
        Console.Write("Quina operació vols fer amb ells (Suma, Resta, Mutiplicació o Divisió?");
        string oper = Console.ReadLine().ToLower(); //l'entrada es convertida a minusculas
        control++;

        switch (oper){
            case "suma":
                Console.WriteLine("Suma: " + (num1+num2));
                control2++;
                break;
            case "resta":
                Console.WriteLine("Resta: "+ (num1-num2));
                control2++;
                break;
            case "multiplicació":
                Console.WriteLine("Multiplicació: "+ (num1*num2));
                control2++;
                break;
            case "divisió":
                Console.WriteLine("Divisió: "+ (Convert.ToDouble(num1)/Convert.ToDouble(num2))); //dona el resultat en decimals si n'hi ha
                control2++;
                break;
            case "finalitzar":
                control2++;
                control++;
                break;
            default:
                Console.WriteLine("Només puc fer operacions arigmetiques bàsiques (Suma, Resta, Multiplicació o Divisió, torna a provar o escriu Finalitzar per sortir!");
                break;
        }
    }while (control2 == 0);
    

}while (control == 2);

Console.WriteLine("Gràcies per fer servir aquesta app!"); //final de la app










