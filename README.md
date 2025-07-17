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
