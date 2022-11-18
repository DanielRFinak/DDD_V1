# Finaktiva Domain Driven Design (DDD) V1

Domain Driven Design (DDD) es una práctica de desarrollo de software que pone el foco en el Dominio del Negocio como faro del proyecto 
y en su Modelo como herramienta de comunicación entre negocio y tecnología.

Este proyecto es una base conceptual para implementar un API Services con DDD en .NET Core.


## Estructura de carpetas

API

	Finaktiva.DDD_1.API

		AplicationServices

		Commands

		Controllers

		Queries

Domain

	Finaktiva.DDD_1.Domain
		
		Entities
		
		Repositories
		
		ValueObjects
	
Infrastructure
	
	Finaktiva.DDD_1.Infrastructure
	
	
## Explicación de estructura

### Contexto SERVICIOS

#### API: Exposición del dominio

	AplicationServices: Implementara los Handle de cada uno de los comandos creados.
	
	Commands: Similar a un DTO, pero llamado comando el cual seteara las variables al inicializar el objeto y sera inmutable, son utilizados por los handlers
	y por el controller API.
	
	Controllers: Expone los EndPoints creados por los métodos GET, POST, PUT, PATH etc. Hace uso de los handlers. Por cada endpoint se implementara un nuevo handler.
	
	Queries: Realiza peticiones a datos externos por ejemplo: otras APIs, bases de datos etc. Se apoya en la capa de Infrastructure.

### Contexto DOMINIO
	
#### Domain: Contiene los modelos del dominio o logica de negocio. Representa las abstracciones de las entidades del negocio, por ejemplo: clientes, proveedores, productos, facturas etc.

	Entities: Representa una abstracción de un objeto real, el cual debe contener un ID, por lo tanto cada entidad debe ser única.
	
	ValueObjects: Son objetos inmutables los cuales definen las características de un objeto entidad creado.
	
	Repositories: Representa la abstracción de los repositorios de datos externos, por ejemplo los métodos CRUD para una entidad, dentro de dominio estos solo son interfaces.

### Contexto Infraestructura
	
#### Infrastructure: 
	
	Implementa las interfaces creadas a Repositories, por lo tanto tiene como dependencia al Domain. En la interfaz es donde se realiza la conexión a las entidades externas, como API, o bases de dato.
	