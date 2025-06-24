namespace MISD_MultipleInstructionSingleData
{
    public class MISD
    {
        public void Ejecutar()
        {
            Console.WriteLine("\n[MISD] Multiple Instruction, Single Data");

            int dato = 10;
            Console.WriteLine($" Dato inicial: {dato}\n");
            // HILO 1: CALCULA EL CUADRO
            Thread t1 = new(() =>
            {
                int resultado = dato * dato;
                Console.WriteLine($"[Hilo 1] Operación: {dato} ^ 2 = {resultado}");
            });
            // HILO 2: CALCULA EL TRIPLE
            Thread t2 = new(() =>
            {
                int resultado = dato * 3;
                Console.WriteLine($"[Hilo 2] Operación: {dato} * 3 = {resultado}");
            });
            // HILO 3: DETERMINA SI ES PAR O IMPAR
            Thread t3 = new(() =>
            {
                string esPar = (dato % 2 == 0) ? "Sí" : "No";
                Console.WriteLine($"[Hilo 3] Operación: ¿{dato} es par?  {esPar}");
            });
            // EJECUTAMOS LOS HILOS
            Console.WriteLine(" Ejecutando los hilos en paralelo...\n");
            t1.Start();
            t2.Start();
            t3.Start();
            // ESPERAR A QUE TODOS LOS HILOS TERMINEN DE CARGAR
            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("\n Todas las operaciones MISD han finalizado.\n");
        }
    }
}
