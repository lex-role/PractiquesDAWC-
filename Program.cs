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
int control = 0;
int num1 = 0;
int num2 = 0;
//inicia un do while mentres control sigui inferior a 2
do{
     do{
        Console.Write("Introdueix un numero: ");
        try {
            num1 = int.Parse(Console.ReadLine());
            control++;
        }catch{
            Console.WriteLine("Introdueix un número valid!");
        }
    }while(control == 0);
    do{
        Console.Write("Intodueix un segón numero: ");
        try {
            num2 = int.Parse(Console.ReadLine());
            control++;
        }catch{
            Console.WriteLine("Introdueix un número valid!"); 
        }
    }while(control==1);
    
    int control2 = 0;

    do{        
        Console.Write("Quina operació vols fer amb ells (Suma, Resta,  Mutiplicació o Divisió?");
        string oper = Console.ReadLine().ToLower();
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
                Console.WriteLine("Divisió: "+ (Convert.ToDouble(num1)/Convert.ToDouble(num2)));
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

Console.WriteLine("Gràcies per fer servir aquesta app!");










