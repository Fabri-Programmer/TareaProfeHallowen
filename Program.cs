
using TareaDeHoyHallowen;

string ha;
int n;
Estudiante e = new Estudiante();
do
{


Console.WriteLine("Bienvenido al sistema de registro de edades\n");
Console.WriteLine("****** MENU *******");
Console.WriteLine("*1 Insertar       *");
Console.WriteLine("*2 Mostrar        *");
Console.WriteLine("*3 Eliminar       *");
Console.WriteLine("*4 Mostrar        *");
Console.WriteLine("*0 Salir          *");
Console.WriteLine("*******************\n");

Console.Write("ingrese una opcion: ");
    


while(!int.TryParse(Console.ReadLine(), out n)|| n>4)
{
    Console.Write("Error: Ingrese opcion: ");
}

switch (n)
{
    case 0: Environment.Exit(0); break;  
    case 1:  e.insertar(); break;
    case 2: e.mostrar();  break;
    case 3:
            Console.Write("\n Ingrese la edad a eliminar: ");
            int ed = int.Parse(Console.ReadLine());
            e.eliminar(ed); break;
    case 4: break;

}
Console.Write("\nDesea regresar al menu: ");
 ha = Console.ReadLine();
    Console.Clear();
    
}while (ha == "si") ;




