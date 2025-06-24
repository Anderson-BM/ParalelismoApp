namespace SIMD_SingleInstructionMultipleData
{
    public class SIMD
    {
        public void Ejecutar()
        {
            // SE INICIALIZAN LOS DATOS
            Console.WriteLine("\n [SIMD] Single Instruction, Multiple Data");
            int[] datos = { 1, 2, 3, 4, 5 };
            Console.WriteLine($" Datos iniciales: {string.Join(", ", datos)}");

            // AQUI SE APLICA LA TAREA A REALIZAR
            Console.WriteLine("\nAplicando la instrucción: multiplicar cada dato por 2");
            for (int i = 0; i < datos.Length; i++)
            {
                int antes = datos[i];
                datos[i] = datos[i] * 2;
                Console.WriteLine($" Dato[{i}] antes: {antes}, después: {datos[i]}");
            }
            // RESULTADOS MOSTRADOS EN PANTALLA
            Console.WriteLine($" \nResultados finales SIMD: {string.Join(", ", datos)}\n");
        }
    }
}
