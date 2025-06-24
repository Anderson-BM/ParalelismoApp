# ParalelismoApp
Como parte de la Asignacion de Programacion Paralela en el ITLA



Desarrolle los siguientes programas
1. SISD (Single Instruction, Single Data): Un solo flujo de instrucciones opera sobre un solo flujo de datos. Es el modelo tradicional de computación secuencial.

2. SIMD (Single Instruction, Multiple Data): Un solo flujo de instrucciones opera sobre múltiples flujos de datos simultáneamente. Se usa en sistemas que procesan grandes conjuntos de datos, como procesamiento de imágenes o operaciones vectoriales.

3. MISD (Multiple Instruction, Single Data): Múltiples flujos de instrucciones operan sobre un solo flujo de datos. Este es el menos común y generalmente se usa en aplicaciones especializadas como sistemas redundantes.

4. MIMD (Multiple Instruction, Multiple Data): Múltiples flujos de instrucciones operan sobre múltiples flujos de datos simultáneamente. Es el modelo más general de sistemas paralelos, como los sistemas multiprocesadores.


Proyecto de Tarea Basado en la Taxonomía de Flynn
Simulación y Comparación de Modelos de Computación Paralela Basados en la Taxonomía de Flynn
1. Implementación de los Modelos Basados en Flynn:

 A. SISD (Single Instruction, Single Data):

   - Descripción: Implementa una operación secuencial donde se procesa un solo flujo de datos con un conjunto de instrucciones.

B. SIMD (Single Instruction, Multiple Data):

   - Descripción: Implementa una operación paralela donde una instrucción actúa sobre múltiples flujos de datos al mismo tiempo.

C. MIMD (Multiple Instruction, Multiple Data):

   - Descripción: Implementa un sistema donde diferentes hilos o tareas procesan diferentes flujos de datos con diferentes instrucciones.

   - Ejemplo: Cada hilo procesa diferentes subconjuntos de datos y aplica diferentes operaciones (por ejemplo, en algunos casos elevar al cuadrado, en otros multiplicar por 10).
