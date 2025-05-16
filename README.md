
# SistemaGestionProductosMVC

Aplicación de escritorio desarrollada en C# Windows Forms bajo arquitectura MVC, que implementa operaciones CRUD conectadas a SQL Server, login con control de roles, y patrones de diseño (Factory, Singleton, Repository, Unit of Work). Se desarrollan versiones ADO.NET.

## Objetivo del Proyecto

Desarrollar una aplicación de gestión de productos con:
- CRUD completo
- Login con roles
- Acceso a datos con ADO.NET
- Principios SOLID
- Patrones de diseño
- Estructura modular por capas

## Estructura del Proyecto

### SistemaGestionProductosMVC/

App Config/           → Contiene el archivo app.config, donde se define la cadena de conexión a SQL Server.

Data/                 → Encapsula el acceso a la base de datos. Está dividida en dos subcarpetas que representan patrones clave

Entities/             → Contiene las clases que representan las entidades del sistema.

Factory/              → Implementa el Patrón Factory, que permite instanciar objetos como el Unit of Work.

Forms/                → Contiene los formularios de la interfaz gráfica.

Services/             → Contiene clases que encapsulan lógica de negocio o validación.

Utils/                → Contiene clases de utilidad general, como la conexión a la base de datos o la gestión de sesión del usuario.

## PARTE 1: Configuración del Proyecto
            Crear solución en Visual Studio    
            Tipo: Windows Forms App (.NET Framework)
            Nombre: SistemaGestionProductosMVC
          
            Agregar carpetas manualmente dentro del proyecto:
              Data, Entities, Factory, Forms, Services, Utils, App Config

## PARTE 2. Conexión a Base de Datos (ADO.NET)
1. app.config
   
connectionStrings: sección que permite a toda la aplicación acceder a la base de datos mediante un nombre clave.

Principios aplicados: SRP (Single Responsibility), la configuración está centralizada y separada del código fuente.

2. DbConnectionSingleton.cs (Utils)

   

## PARTE 3. Diseño de la Base de Datos (SQL Server)

## PARTE 4. Módulo de Login
          Usuario.cs (Entities)
          SesionUsuario.cs (Utils)
          AuthService.cs (Services)
          LoginForm.cs (Forms)

## PARTE 5. Crear la entidad Producto.cs (Entities)

## PARTE 6. Crear la interfaz IProductoRepository.cs (Data/Repositories)

## PARTE 7. Implementar ProductoRepository.cs (Data/Repositories)

## PARTE 8. Crear el formulario FrmGestionProductos (Forms)
          Diseño:
              label: lblNombre, lblPrecio, lblStock
              TextBox: txtNombre, txtPrecio, txtStock
              DataGridView: dgvProductos
              Buttons: btnAgregar, btnActualizar, btnEliminar, btnLimpiar

## PARTE 9. Interfaz IUnitOfWork.cs

## PARTE 10. Clase UnitOfWork.cs

## PARTE 11. Interfaz IRepositoryFactory.cs 

## PARTE 12. Clase RepositoryFactory.cs

## PARTE 13. Usar Unit of Work en el formulario FrmGestionProductos

## PARTE 14. Realizar pruebas
