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


Dia 3

Actividades

-Termine el endpoint para crear cuentas, validando que el nombre no este vacio y que el valor inicial no sea negativo.
-Implemente el endpoint de consignacion (deposit) donjde se busca la cuenta por numero, se suma el dinero al balance y se guarda tambien el movimiento en la tabla de transacciones.
-Tambien hice el endpoint de retiro (withdraw), donde valido que la cuenta exista y que tenga fondos suficientes antes de desconectar el dinero.
-Corregi problemas con la base de datos y la volvi  a crear para que coincidiera con los cambios del modelo.
-Cree el endpoint para consultar saldo(balance)
-Realice pruebas usando Postman para validar que los endpoint funcionaran  correctamente

Problemas enfrentados

-Error al actualizar la base de datos por que ya existian tablas creadas
-Problemas con migraciones al cambiar el modelo(se dañaron y toco recrearlas)
-Dudas sobre como estructurar correctamente los modelos 

Tiempo

Total de 4 horas


Dia 4

Actividades

-Cree la carpeta scripts para organizar los archivos SQL del proyecto
-Realice un script  para insertar varias cuentas de prueba en la base de datos
-Cree un script para actualizar algunas cuentas,modificando el valor inicial y el saldo
- Hice un script para registrar movimientos (consignaciones y retiros) directamente en la base de datos.
-Desarrolle una consulta (JOIN) para mostrar un resumen por cuenta con totales de depósitos y retiros.

Problemas enfrentados

-Duda sobre qué datos debían coincidir entre InitialAmount y Balance.
-Algo de inseguridad al momento de escribir los scripts, ya que no es algo que use normalmente.
-Tuve que ajustar varias veces el enfoque para entender bien qué pedía exactamente el requerimiento.

Tiempo aproximado 
Alrededor de 3 horas 


Dia 5 


Actividades


-Implementé el endpoint para consultar historial de movimientos de una cuenta (GET /api/accounts/transactions/{accountNumber}).
-Realicé pruebas en Postman para validar consignaciones, retiros, saldo e historial.
-Revisé el funcionamiento general de los endpoints creados.
-Organicé y guardé los scripts SQL del proyecto.
-Validé que la API siguiera conectando correctamente con la base de datos.
-Dejé preparada la estructura final del proyecto para continuar documentación.

Problemas enfrentados

-El endpoint de historial devolvía lista vacía y fue necesario revisar datos almacenados en transacciones.
-Algunos errores 404 en Postman por usar rutas incorrectas.
-Dudas sobre cómo enviar correctamente datos en retiros y consignaciones.

Tiempo aproximado

Alrededor de 3 horas.


Dia 6 


Actividades


-Probé todos los scripts SQL directamente en SQL Server Management Studio.
-Corregí errores en nombres de tablas, columnas y datos usados en scripts.
-Validé el script de actualización de cuentas modificando 5 registros correctamente.
-Ejecuté y comprobé el reporte JOIN solicitado en la prueba técnica.
-Organicé carpeta de evidencias con capturas de funcionamiento.
-Exporté colección de Postman para adjuntar en la entrega.
-Mejoré y completé el archivo README.md.
-Documenté instalación local, endpoints, scripts y estructura del proyecto.
-Preparé el proyecto para entrega final en GitHub y archivo .zip.

Problemas enfrentados

-Algunos scripts no afectaban filas porque los números de cuenta no coincidían con registros reales.
-Errores por usar nombres incorrectos de tablas (Account en lugar de Accounts).

Tiempo aproximado

Entre 4 y 5 horas.