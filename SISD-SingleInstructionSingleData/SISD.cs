namespace SISD_SingleInstructionSingleData
{
    public class SISD
    {
        public void Ejecutar()
        {
            // SE LE SOLICITAN LOS DATOS A EL USUARIO
            Console.WriteLine("\n [SISD] Single Instruction, Single Data");
            Console.WriteLine("Introduzca un Numero:");

            // SE ALOJA EL DATO ESTA VARIABLE LLAMADA DATA
            int data = int.Parse(Console.ReadLine()!); 
            Console.WriteLine($" Dato ingresado: {data}");


            // AQUI SE REALIZAN LAS OPERACIONES NECESARIAS CON EL DATO INGRESADO POR EL USUARIO
            data = data + 2;
            Console.WriteLine($" Sumar 2: {data}");

            data = data * 3;
            Console.WriteLine($" Multiplicar por 3: {data}");

            data = data - 5;
            Console.WriteLine($" Restar 5: {data}");

            // DICHO RESULTADO SE IMPRIME EN PANTALLA
            Console.WriteLine($"Resultado final SID: {data}");
        }
    }
}
