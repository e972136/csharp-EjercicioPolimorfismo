namespace Gaspar{
    public class EmpleadoHora:Empleado{
        public override double calculoSalario(){
            Console.Write($"Cantidad horas trabajadas de {nombre}: ");
            double nHoras = Convert.ToDouble( Console.ReadLine());
            double calculo = nHoras * salarioHora;
            return calculo;
        }

    }
}