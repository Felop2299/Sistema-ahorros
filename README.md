Sistema de Gestión de Cuentas de Ahorros

API REST desarrollada en ASP.NET Core para la administración de cuentas de ahorro.
Permite crear cuentas, realizar consignaciones, retiros, consultar saldo e historial de movimientos.


Tecnologías utilizadas

-ASP.NET Core (.NET)
-C#
-Entity Framework Core
-SQL Server
-Postman (pruebas funcionales)
-Git / GitHub

Repositorio

https://github.com/Felop2299/Sistema-ahorros


Funcionalidades principales

-Crear cuenta de ahorros
-Consignar dinero
-Retirar dinero
-Consultar saldo actual
-Consultar historial de transacciones
-Persistencia en base de datos SQL Server


Cómo ejecutar el proyecto en ambiente local


1. Clonar el repositorio
git clone https://github.com/Felop2299/Sistema-ahorros.git
2. Ingresar a la carpeta del proyecto
cd Sistema-ahorros
3. Configurar conexión a base de datos

Editar appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=SistemaAhorrosDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
4. Ejecutar migraciones
dotnet ef database update
5. Ejecutar la aplicación
dotnet run
6. URL local
http://localhost:5243


Endpoints disponibles


1. Crear cuenta

POST

/api/accounts/create

Body:

{
  "ownerName": "Peter",
  "initialAmount": 1000
}

Respuesta esperada:

{
  "message": "Account created successfully",
  "accountNumber": "GUID_GENERATED"
}

2. Consignar dinero

POST

/api/accounts/deposit

Body:

{
  "accountNumber": "667e26c4-d802-4b53-a77d-820cac4684db",
  "amount": 500
}

Respuesta:

"Deposit of 500 was successful"
3. Retirar dinero

POST

/api/accounts/withdraw

Body:

{
  "accountNumber": "667e26c4-d802-4b53-a77d-820cac4684db",
  "amount": 200
}

Respuesta:

"Withdraw of 200 was successful"
4. Consultar saldo

GET

/api/accounts/balance/{accountNumber}

Ejemplo:

/api/accounts/balance/667e26c4-d802-4b53-a77d-820cac4684db
5. Consultar historial de movimientos

GET

/api/accounts/transactions/{accountNumber}

Ejemplo:

/api/accounts/transactions/667e26c4-d802-4b53-a77d-820cac4684db


Base de datos

Se utilizó SQL Server con Entity Framework Core.

Tablas principales:

-Accounts
-Transactions


Características:

Llaves primarias autoincrementales (PK)
-Relación mediante llave foránea (FK)
-Persistencia de movimientos financieros


Scripts SQL incluidos

En la carpeta scripts/:

-insert_accounts.sql
    Inserta 10 cuentas ficticias.
-update_accounts.sql
    Modifica el valor inicial de 5 cuentas.
-transactions.sql
    Inserta consignaciones y retiros.
-report.sql
Consulta JOIN con reporte plano:
    -Nombre Persona
    -Número Cuenta
    -Total Consignaciones
    -Total Retiros
    -Valor Inicial
    -Saldo Actual

    Colección Postman

El proyecto incluye colección Postman con pruebas funcionales de todos los endpoints.

Ubicación:

/Postman/


Estructura general del proyecto
Sistema-ahorros/
├── Controllers/
├── Models/
├── Data/
├── Migrations/
├── scripts/
├── postman/
├── README.md
├── Program.cs
├── appsettings.json



Posibles mejoras futuras
Autenticación con JWT
Frontend web consumiendo la API
Dockerización
Validaciones avanzadas
Logs y auditoría


Autor

Andres Felipe Ortega

GitHub: https://github.com/Felop2299