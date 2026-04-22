Registro de Progreso

Dia 1 

Actividades 

-Instalacion de .NET SDK
-Instalacion de SQL server y SSMS
-Creacion del proyecto Web API
-Configuracion de Swagger
-Creacion de modelos (Account, Transaction)
-Configuracion de Entity Framework
-Creacion de base de datos con migracion

Problemas encontrados

-Errores con versiones de Entity Framework( resuelto alineando las versiones)
-Error de proceso bloqueado al ejecutar dotnet run 
-Error al ejecutar Swagger(404) la planilla inicial usaba OpenAPI sin interfaz Swagger, instale Swashbuckle y configure manualmente Swagger


Tiempo invertido

Aproximadamente 3 - 4 horas 


Dia 2

Actividades

- Creé la carpeta de Controllers 
- Hice el AccountsController
-Logré conectar el controller con la base de datos usando el DbContext
- Cree un modelo nuevo para recibir datos del depósito (DepositRequest)
-Hice el endpoint para consignar (POST /api/accounts/deposit)
-Agregué unas validaciones básicas para que no lleguen datos vacíos

Problemas enfrentados

-Me enrede un poco con los namespaces, no entendia por que no encontraba el Data
-Tuve varios errores de sintaxis por cosas pequeñas (como escribir mal HttpPost  y ok)
-Todavia me confunde un poco la organizacion entre Models.controllers y Data

Tiempo 

Entre 1 hora y media a 2(andaba cansado no me fije muy bien)