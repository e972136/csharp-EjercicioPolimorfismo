namespace Gaspar{
    public class EmpleadoDia:Empleado{
        public override double calculoSalario(){
            Console.Write($"Dias trabajados de {nombre} : ");
            double nDias = Convert.ToDouble( Console.ReadLine());
            double calculo = nDias * salarioHora * 8.0;
            return calculo;
        }        
    }
}