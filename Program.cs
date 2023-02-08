namespace Matematicas { 
    class OperacionesBasicas{
        public static void Main(String[] args){
            int numeroA, numeroB, resultado;
            Console.WriteLine("Introduce el primer número: ");
            numeroA = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            numeroB = int.Parse(Console.ReadLine());
            resultado = numeroA + numeroB;
            Console.WriteLine("LA SUMA ES: " + numeroA + "+" + numeroB + " =" + resultado);
            resultado = numeroA - numeroB;
            Console.WriteLine("LA RESTA ES: " + numeroA + "-" + numeroB + " =" + resultado);
            resultado = numeroA * numeroB;
            Console.WriteLine("LA MULTIPLICACIÓN ES: " + numeroA + "*" + numeroB + " =" + resultado);
            resultado = numeroA / numeroB;
            Console.WriteLine("LA DIVISIÓN ES: " + numeroA + "/" + numeroB + " =" + resultado);
            resultado = numeroA % numeroB;
            Console.WriteLine("EL RESTO ES: " + numeroA + "&" + numeroB + " =" + resultado);
        }
    }
}