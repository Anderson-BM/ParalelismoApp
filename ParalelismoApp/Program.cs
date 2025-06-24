// See https://aka.ms/new-console-template for more information
using MIMD_MultipleInstructionMultipleData;
using MISD_MultipleInstructionSingleData;
using SIMD_SingleInstructionMultipleData;
using SISD_SingleInstructionSingleData;
// ---------------------------------------------------------------------------------------
Console.WriteLine("Anderson Batista Mateo ---- 2023-1396");


// ---------------------------------------------------------------------------------------
while (true) 
{
    // CREACION DE EL MENU CON LAS ORDENES SOLICITAS AL APLICATIVO
    Console.WriteLine("\n------MENU INICIAL DE SIMULACION -------");
    Console.WriteLine("\n  1)------SISD (Single Instruction, Single Data) -------");
    Console.WriteLine("\n  2)------SIMD (Single Instruction, Multiple Data) -------");
    Console.WriteLine("\n  3)------MISD (Multiple Instruction, Single Data) -------");
    Console.WriteLine("\n  4)------MIMD (Multiple Instruction, Multiple Data) -------");
    Console.WriteLine("\n  0)---SALIR) ----");
    Console.WriteLine("\n  ------ELIGE UNA OPCION -------");
    int opcion = int.Parse(Console.ReadLine()!);

    // ---------------------------------------------------------------------------------------
    switch (opcion) 
    {
         case 1: 
             new SISD().Ejecutar();
             break;
        case 2:
            new SIMD().Ejecutar();
            break;
        case 3:
            new MISD().Ejecutar();
            break;
        case 4:
            new MIMD().Ejecutar();
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}
// ---------------------------------------------------------------------------------------
