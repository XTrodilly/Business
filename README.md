
# Prueba Técnica - .NET Software Developer

Este proyecto corresponde a una prueba técnica desarrollada en ASP.NET MVC 5, utilizando buenas prácticas de diseño y codificación orientadas a objetos.

## Requisitos del entorno

- Visual Studio 2017 o superior (recomendado Visual Studio 2022)
- .NET Framework 4.7.2
- NuGet Package Manager (para restaurar paquetes)
- Acceso a internet (para consumo de API externa)

## Tecnologías utilizadas

- ASP.NET MVC 5
- C#
- HTML/CSS con Bootstrap
- JavaScript
- Consumo de API REST con HttpClient
- Test Unitario con MSTest
- Principios de Programación Orientada a Objetos (encapsulamiento, abstracción)

## Estructura del proyecto

- **Models**: Clases que representan la entidad `Employee`.
- **DAL (Data Access Layer)**: Contiene la lógica para consumir la API externa de empleados.
- **BLL (Business Logic Layer)**: Contiene la lógica de negocio (cálculo de salario anual).
- **Controllers**: Controladores MVC y WebAPI.
- **Views**: Vistas Razor para mostrar y buscar empleados.
- **Tests**: Proyecto de prueba unitaria con al menos un método de la capa de negocio.

## API utilizada

Se utiliza una API externa mockeada en MockAPI.io:

```
https://68328e47c3f2222a8cb2aa04.mockapi.io/Employees
```

## Funcionalidad

- Visualización del listado completo de empleados.
- Búsqueda por ID (opcional).
- Cálculo del salario anual (`salario * 12`) en la capa de negocio.
- Interfaz limpia y responsiva utilizando Bootstrap.
- Resultado mostrado en tabla.

## Cómo ejecutar el proyecto

1. Clonar el repositorio:

```bash
git clone https://github.com/XTrodilly/Business.git
```

2. Abrir el archivo `.sln` con Visual Studio.

3. Restaurar los paquetes NuGet. 

4. Compilar la solución.

5. Ejecutar el proyecto (F5) y abrir en el navegador.

## Notas

- Si el ID ingresado es válido, se muestra solo el empleado correspondiente.
- Si no se ingresa ID, se muestra el listado completo.
- Si el ID no existe, se muestra un mensaje informativo. 
- Se incluyó un test unitario que valida el cálculo de salario anual.

---

Proyecto desarrollado como parte de una evaluación técnica para el cargo de desarrollador .NET.
