using System;

namespace MaquinaCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            CafeMachine maquina = new CafeMachine();

            Console.WriteLine("Seleccione el tamaño del vaso: 1) Pequeño 2) Mediano 3) Grande");
            int tamañoVaso = int.Parse(Console.ReadLine());

            VasoTamaño tamaño;
            switch (tamañoVaso)
            {
                case 1:
                    tamaño = VasoTamaño.Pequeño;
                    break;
                case 2:
                    tamaño = VasoTamaño.Mediano;
                    break;
                case 3:
                    tamaño = VasoTamaño.Grande;
                    break;
                default:
                    Console.WriteLine("Selección no válida.");
                    return;
            }

            Console.WriteLine(maquina.SeleccionarVaso(tamaño));

            Console.WriteLine("Ingrese la cantidad de azúcar (cucharadas):");
            int cucharadas = int.Parse(Console.ReadLine());
            Console.WriteLine(maquina.SeleccionarAzucar(cucharadas));

            Console.WriteLine(maquina.RecogerVaso());
        }
    }
}
