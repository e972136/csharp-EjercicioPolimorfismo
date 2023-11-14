using Gaspar;

List<Empleado> empleados = new List<Empleado>();
empleados.Add(new EmpleadoHora());
empleados.Add(new EmpleadoDia());

foreach(Empleado x in empleados){
    x.obtenerDatos();
}

foreach(Empleado x in empleados){
    double salario = x.calculoSalario();
    Console.WriteLine($"Salario total: {salario}");
}
