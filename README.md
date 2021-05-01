# InscripcionesWebApp

## Descripción 📋

API REST,  **ASP.NET.Core 3.1** se usó **Entity Framework** para crear migraciones y generar la BD **SQLite**.
Se agregó un elemento **Aspirante.cs** que es la clase para modelar la estructura de la tabla.

### Aspirante
```
*    int Id,
*    String Nombre,
*    String Apellido,
*    int Edad,
*    String Casa
```

### ApplicationDBContext.cs 
Clase de contexto para acceder al modelo de datos

### Comandos para instalación de Entity Framework con 
```
    PM> install-package Microsoft.EntityFrameworkCore
    PM> install-package Microsoft.EntityFrameworkCore.Design
    PM> install-package Microsoft.EntityFrameworkCore.Sqlite
```

### AspirantesController.cs
Contiene el código para la solicitud GET / PUT / POST/ DELETE

## Ejecutando las pruebas ⚙️

La aplicación consta de 5 métodos para mostrar, insertar, modificar y eliminar los
registros de la base de datos

### Petición GET:
Muestra todos los registros en la base de datos
**Link Ejemplo:**
```
https://localhost:44337/api/aspirante
```
![image](https://user-images.githubusercontent.com/79678735/116792118-b4c6c180-aa8c-11eb-9208-f50915c1736e.png)


### Petición Get para un aspirante:
Muestra solo el registro del aspirante seleccionado por su id
**Link Ejemplo:**
```
https://localhost:44337/api/aspirantes/1
```
![image](https://user-images.githubusercontent.com/79678735/116792131-cc05af00-aa8c-11eb-86cc-dee3b02a3b8b.png)


### Petición Post:
Inserta los datos de un aspirante en la base de datos no es necesario insertar
el id ya que es una llave primaria y auto-incremental
**Link Ejemplo:**
```
https://localhost:44337/api/aspirantes
```
![image](https://user-images.githubusercontent.com/79678735/116792164-fd7e7a80-aa8c-11eb-93c9-9546f4410591.png)


### Petición Put:
Modifica el registro de la base de datos seleccionando el aspirante por su id
**Link Ejemplo:**
```
https://localhost:44337/api/aspirantes/1
```
![image](https://user-images.githubusercontent.com/79678735/116792178-0ff8b400-aa8d-11eb-83f6-d1e9b5340f36.png)


### Petición Delete:
Elimina el registro de un aspirante por su id
**Link Ejemplo:**
```
https://localhost:44337/api/aspirantes/1
```
![image](https://user-images.githubusercontent.com/79678735/116792199-269f0b00-aa8d-11eb-80e7-e46589a372cb.png)


## Herramientas 🛠️

* [Visual Studio](https://visualstudio.microsoft.com/es/) - IDE
* [Entity Framework](https://docs.microsoft.com/en-us/ef/) - Mapeador de bases de datos
* [SQLite](https://www.sqlite.org/index.html) - BD
* [SQLiteStudio](https://sqlitestudio.pl/) - GUI BD
* [Git](https://git-scm.com/) - Control de Versiones
* [Postman](https://www.postman.com/) - Test
