# Finaktiva Domain Driven Design (DDD) V1

Domain Driven Design (DDD) es una práctica de desarrollo de software que pone el foco en el Dominio del Negocio como faro del proyecto 
y en su Modelo como herramienta de comunicación entre negocio y tecnología.

Para lograr una comunicacion efectiva entre NEGOCIO y TECNOLOGÍA se utiliza el lenguaje Ubiquo

## Lenguaje Ubiquo

Es una colección de términos y definiciones utilizadas por todo el equipo tanto equipos técnico como no técnico, para lograr esto dentro del desarrollo del dominio se utilizara
terminología del negocio y no terminología técnica, de forma que ambos equipos puedan guiar el desarrollo del software, bajo un entendimiento real de lo que ocurre en el negocio.

Para esto utilizaremos terminología real del negocio incluso para nombrar métodos o funciones dentro del código, por ejemplo: Si necesitamos crear un método para realizar suscripciones mensuales de un cliente, normalmente lo llamaríamos:

	CreateSuscription (Esto seria un error ya que no describe de forma no técnica lo que realiza el método)

	ClientSignupMonthlySubscription (Este nombre describe exactamente lo que realizara el método de forma que alguien no técnico puede entenderlo)

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

	Queries: Realiza peticiones de LECTURA a datos externos por ejemplo: otras APIs, bases de datos etc. Se apoya en la capa de Infrastructure.

### Contexto DOMINIO
	
#### Domain: Contiene los modelos del dominio o logica de negocio. Representa las abstracciones de las entidades del negocio, por ejemplo: clientes, proveedores, productos, facturas etc.

	Entities: Representa una abstracción de un objeto real, el cual debe contener un ID, por lo tanto cada entidad debe ser única.

	ValueObjects: Son objetos inmutables los cuales definen las características de un objeto entidad creado.

	Repositories: Representa la abstracción de los repositorios de datos externos, por ejemplo los métodos CRUD para una entidad, dentro de dominio estos solo son interfaces.

### Contexto Infraestructura
	
#### Infrastructure: 
	
	Implementa las interfaces creadas a Repositories, por lo tanto tiene como dependencia al Domain. En la interfaz es donde se realiza la conexión a las entidades externas, como API, o bases de dato.
	