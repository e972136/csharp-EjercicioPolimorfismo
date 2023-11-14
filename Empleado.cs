namespace Gaspar{
    public abstract class Empleado{
        public int id;
        public String nombre;
        public double salarioHora;
        public void obtenerDatos(){
            Console.Write("id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Salario hora: ");
            salarioHora = Convert.ToDouble(Console.ReadLine());
        }

        public abstract double calculoSalario();        
    }
}