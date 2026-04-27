# Sistema de Gestión de Cuentas de Ahorros


Consiste en una API REST construida en ASP.NET Core para gestionar cuentas de ahorro, permitiendo crear cuentas, realizar consignaciones, retiros, consultar saldo y ver el historial de movimientos.

## Tecnologías utilizadas

* ASP.NET Core (.NET)
* C#
* Entity Framework Core
* SQL Server
* Postman
* Git / GitHub

## Repositorio

https://github.com/Felop2299/Sistema-ahorros

## Funcionalidades implementadas

* Crear cuenta de ahorros
* Consignar dinero
* Retirar dinero
* Consultar saldo de una cuenta
* Consultar historial de transacciones
* Persistencia de datos en SQL Server

## Cómo ejecutar el proyecto en ambiente local

### 1. Clonar el repositorio

```bash 
git clone https://github.com/Felop2299/Sistema-ahorros.git
```

### 2. Ingresar a la carpeta del proyecto

```bash 
cd Sistema-ahorros
```

### 3. Configurar la cadena de conexión

Editar el archivo `appsettings.json` con la conexión local de SQL Server:

```json 
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=SistemaAhorrosDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 4. Ejecutar migraciones

```bash 
dotnet ef database update
```

### 5. Ejecutar la aplicación

```bash
dotnet run
```

### 6. URL local

```text 
http://localhost:5243
```

## Endpoints principales

### Crear cuenta

`POST /api/accounts/create`

```json 
{
  "ownerName": "Peter",
  "initialAmount": 1000
}
```

### Consignar dinero

`POST /api/accounts/deposit`

```json
{
  "accountNumber": "GUID",
  "amount": 500
}
```

### Retirar dinero

`POST /api/accounts/withdraw`

```json 
{
  "accountNumber": "GUID",
  "amount": 200
}
```

### Consultar saldo

`GET /api/accounts/balance/{accountNumber}`

### Consultar historial de movimientos

`GET /api/accounts/transactions/{accountNumber}`

## Base de datos

Se utilizó SQL Server con Entity Framework Core.

Tablas principales:

* Accounts
* Transactions

Características implementadas:

* Llaves primarias autoincrementales
* Relación entre cuentas y transacciones mediante llave foránea
* Registro de movimientos realizados

## Scripts SQL incluidos

En la carpeta `Scripts/` se incluyen los siguientes archivos:

* `insert_accounts.sql` → Inserción masiva de 10 cuentas ficticias
* `update_accounts.sql` → Actualización del valor inicial de 5 cuentas
* `insert_transactions.sql` → Inserción de consignaciones y retiros
* `report_join.sql` → Reporte general con JOIN

## Pruebas realizadas

Se incluye colección de Postman con pruebas de los endpoints principales.

Ubicación:

```text 
Postman/
```

También se adjunta carpeta de evidencias con capturas de funcionamiento.

## Estructura general del proyecto

```text 
Sistema-ahorros/
├── Controllers/
├── Models/
├── Data/
├── Migrations/
├── Scripts/
├── Postman/
├── Evidencias/
├── README.md
```

## Mejoras futuras

* Implementar autenticación con JWT
* Crear frontend web para consumir la API
* Dockerizar la aplicación
* Agregar validaciones adicionales
* Mejorar logs y auditoría

## Autor

Andres Felipe Ortega

GitHub: https://github.com/Felop2299
