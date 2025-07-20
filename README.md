# 🧑‍💼 Sistema Web de Mantenimiento de Trabajadores

Proyecto de desarrollo de software en ASP.NET Core (mínimo .NET 5) para realizar el mantenimiento de trabajadores utilizando Entity Framework Core, procedimientos almacenados en SQL Server, Bootstrap 5 y GitHub como control de versiones.

---

## 🛠️ Tecnologías Utilizadas

- ASP.NET Core MVC (.NET 5+)
- Entity Framework Core
- SQL Server 2019+
- Bootstrap 5
- GitHub (repositorio público)
- HTML + Razor Pages
- Procedimientos almacenados (`Stored Procedures`)

---

## 📁 Estructura del Proyecto

```plaintext
├── Controllers/
│   └── TrabajadorController.cs
├── Data/
│   ├── TrabajadorRepository.cs
│   └── TrabajadoresContext.cs
├── Models/
│   ├── Trabajador.cs
│   ├── TrabajadorViewModel.cs
│   ├── Departamento.cs
│   ├── Provincia.cs
│   └── Distrito.cs
├── Views/
│   └── Trabajador/
│       └── Index.cshtml
├── wwwroot/
│   └── Bootstrap + JS
├── appsettings.json
└── README.md




Prueba Desarrollo Software .Net Core 
Se desea desarrollar un mantenimiento web de trabajadores con las siguientes indicaciones: 
1. Se requiere crear el proyecto en Net Core (Minimo Net 5) 
2. Utilizar Entityframework para conexión a la BD 
3. Realizar la creación del listado de los trabajadores registrados. 
a. Para el método listar será a su criterio / preferible usar store procedure 
4. Opción Crear Trabajador 
a. El cual puede ser a su criterio / preferible mediante un modal 
5. Opción Actualizar Trabajador 
a. El cual puede ser a su criterio / preferible mediante un modal 
6. Eliminar un Trabajador 
a. El cual puede ser a su criterio / preferible con un mensaje de validación “¿Está seguro de eliminar el 
registro?” 
7. Bonus: Bandeja de Trabajadores Registrados 
a. Agregar Filtro Por Sexo 
b. Pintar Fila del listado Azul Masculino | Naranja Femenino 
Consideraciones: 
• Nombre de base de datos: TrabajadoresPrueba 
• Utilizar Net Core (Minimo Net 5) 
• Utilizar Base de datos SQL SERVER y Script adjunto 
• Utilizar Bootstrap de preferencia u otra biblioteca  
• Utilizar Github como control de versiones (publico)
