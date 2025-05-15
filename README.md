PARTE 1: Configuración del Proyecto

    1. Crear solución en Visual Studio
          Tipo: Windows Forms App (.NET Framework)
          Nombre: SistemaGestionProductosMVC
          
    2. Agregar carpetas manualmente dentro del proyecto:
          Data, Entities, Factory, Forms, Services, Utils, App Config

PARTE 2. Conexión a Base de Datos (ADO.NET)
          1. app.config
          2. DbConnectionSingleton.cs (Utils)

PARTE 3. Diseño de la Base de Datos (SQL Server)

PARTE 4. Módulo de Login
          Usuario.cs (Entities)
          SesionUsuario.cs (Utils)
          AuthService.cs (Services)
          LoginForm.cs (Forms)

PARTE 5. Crear la entidad Producto.cs (Entities)

PARTE 6. Crear la interfaz IProductoRepository.cs (Data/Repositories)

PARTE 7. Implementar ProductoRepository.cs (Data/Repositories)

PARTE 8. Crear el formulario FrmGestionProductos (Forms)
          Diseño:
              label: lblNombre, lblPrecio, lblStock
              TextBox: txtNombre, txtPrecio, txtStock
              DataGridView: dgvProductos
              Buttons: btnAgregar, btnActualizar, btnEliminar, btnLimpiar

PARTE 9. Interfaz IUnitOfWork.cs

PARTE 10. Clase UnitOfWork.cs

PARTE 11. Interfaz IRepositoryFactory.cs 

PARTE 12. Clase RepositoryFactory.cs

PARTE 13. Usar Unit of Work en el formulario FrmGestionProductos

PARTE 15. Realizar pruebas
