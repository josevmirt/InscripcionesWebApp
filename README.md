# InscripcionesWebApp

La aplicación consta de 5 método para mostrar, insertar, modificar y eliminar los
registros de la base de datos

##Petición GET:
Muestra todos los registros en la base de datos
###Link: 
```
https://localhost:44337/api/aspirante
```
##Petición Get para un aspirante
Muestra solo el registro del aspirante seleccionado por su id
###Link:
```
https://localhost:44337/api/aspirantes/1
```
##Petición Post
Inserta los datos de un aspirante en la base de datos no es necesario insertar
el id ya que es una llave primaria y auto-incremental
###Link: 
```
https://localhost:44337/api/aspirantes
```
##Petición Put
Modifica el registro de la base de datos seleccionando el aspirante por su id
###Link:
```
https://localhost:44337/api/aspirantes/1
```
##Petición Delete
Elimina el registro de un aspirante por su id
###Link: 
```
https://localhost:44337/api/aspirantes/1
```
