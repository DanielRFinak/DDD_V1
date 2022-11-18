# Finaktiva Domain Driven Design (DDD) V1

Domain Driven Design (DDD) es una práctica de desarrollo de software que pone el acento en el Dominio del Negocio como faro del proyecto 
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

#### API: Exposicion del dominio

	AplicationServices: Implementara los Handle de cada uno de los comandos creados.
	
	Commands: Similar a un DTO, pero llamado comando el cual seteara las variables al inicializar el objeto y sera inmutable, son utlizados por los handlers
	y por el controller API.
	
	Controllers: Expone los EndPoints creados por los metodos GET, POST, PUT, PATH etc. Hace uso de los handlers. Por cada endpoint se implementara un nuevo handler.
	
	Queries: Realiza peticiones a datos externos por ejemplo: otras APIs, bases de datos etc. Se apoya en la capa de Infrastructure.
	
#### Domain: Contiene los modelos del dominio o logica de negocio. Representa las abstracciones de las entidades del negocio, por ejemplo: clientes, proveedores, productos, facturas etc.

	Entities: Representa una abstracion de un objeto real, el cual debe contenir un ID, por lo tanto cada entidad debe ser unica.
	
	ValueObjects: Son objetos inmutables los cuales definen las caracteristicas de un objeto entidad creado.
	
	Repositories: Representa la abstraccion de los repositorios de datos externos, por ejemplo los metodos CRUD para una entidad, dentro de dominio estos solo son interfaces.
	
#### Infrastructure: 
	
	
	