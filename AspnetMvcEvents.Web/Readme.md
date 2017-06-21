# Hands-On-Lab

### Caso de Estudio

Se procedera a crear un sitio web basado en ***ASP.NET MVC***, en donde se lleve el control de registro de eventos y presentadores en una convención, registrando dicha informacion por medio de un ***ORM*** como lo es ***Entity Framework*** alojandola en ***SQL Server Express Edition***.

#### Ejercicios

Realizar los siguientes ejercicios del hands-on lab:

1. Preparar la solución para la conexión hacia la base de datos

> Tiempo estimado para terminar este hands-on lab: **120 minutos**

#### 1. Preparar la solución para la conexión hacia la base de datos

1.1 Se procede a instalar Entity Framework mediante *NuGet Packages* dando click derecho sobre el proyecto **AspnetMvcEvents.Web** seleccionando la opcion **`Manage NuGet Packages`**

![Image002](Resources/Images/image002.png)

![Image003](Resources/Images/image003.png)

1.2 Posteriormente, agregar la seccion `connectionStrings` en el archivo **`web.config`** con los datos de conexion a la base de datos donde será alojada la información:

![Image004](Resources/Images/image004.png)

Texto en archivo `web.config`

```xml
<connectionStrings>
	<add name="AspnetMvcEvents"
			connectionString="Data Source=(localdb)\MSSQLLocalDB;Database=Events;Integrated Security=True"
			providerName="System.Data.SqlClient" />
</connectionStrings>
```

1.3 Agregar nuevo proyecto a la solucion denominado **"AspnetMvcEvents.Data"** de tipo `Class Library (.NET Framework)` y borrar el archivo *Class1.cs* que se genera por defecto.

1.4 En el proyecto del punto anterior también se deberá habilitar **Entity Framework 6** por medio de NuGet Packages.

1.5 Agregar el mismo *connectionString* del punto **1.2** pero ahora en el archivo `App.config` dentro del proyecto `AspnetMvcEvents.Data` con la finalidad de ser utilizado para la ejecucion de Migrations con **Entity Framework**.

1.6 Crear dos carpetas dentro del proyecto AspnetMvcEvents.Data deniminadas **Context** y **Entities** como se muestra en la siguiente imagen:

![image005](Resources/Images/image005.png)

1.7 Ya creadas las carpetas se procede a crear el contexto donde estaran especificadas las entidades que representaran a las tablas fisicas a nivel base de datos (Proceso de Mapping de Entity Framework), crear una clase denominada "EventsContext.cs" dentro del folder "Context" con el siguiente código:

```csharp
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetMvcEvents.Data.Context
{
	public class EventsContext : DbContext
	{
		public EventsContext()
			: base("AspnetMvcEvents") { }

		#region Entidades por IDbSet

		#endregion
	}
}
```

1.x Habilitar Migrations de EF sobre el proyecto *AspnetMvcEvents.Data* ejecutando la siguiente instruccion por medio de **Package Manager Console** habilitandolo dando la siguiente combinacion **`Ctrl+Q`**, esribir `package` en el Quick Launch y seleccionar la primera opcion:

```
PM> 
```