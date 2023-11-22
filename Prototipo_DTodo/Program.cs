using Prototipo_DTodo;

Empresa empresa = new Empresa("D'Todo");

///// Empleados //////

empresa.ContratarEmpleado("Juan");

Empleado empleado = empresa.Empleados[0];

///// Productos //////

empresa.AgregarProducto("Lapices", 2);

Producto producto = empresa.Productos[0];

///// Alertas //////

empleado.CrearAlerta("Alerta1", 2);

///// Testing /////

empleado.CntProductosDisponibles();

empleado.CntProductoEspecifico(producto.Nombre);

// Alertas:

empleado.CancelarAlerta("Alerta1");

empleado.ConfigurarAlerta("Alerta1");

