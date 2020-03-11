# Wildbit excercise

For this solution I consired 2 possible alternatives, using an Event Bus to publish and subscribe messages (It could be RabbitMQ or Kafka for example).

1. API's call MessageRouter class directly and the router publishes to a Queue to which the mail sender component is subscribed.
This way the availability can be achieved by implementing a HA cluster for the Event Bus and scalability and performance by adding more instances of the mailer component.

2. API's publish a message to a Queue and a MessageRoutingService that is subscribed to that queue.
This way the availability can be achieved by implementing a HA cluster for the Event Bus and scalability and performance by adding more instances of the RoutingService.


The MessageRouterService class uses a Factory class to create the appropriate instance depending of the type of mail, using a Strategy pattern which makes it easy to add new implementations for different types of mails. 
This internally calls the EmailValidatorService that evaluates the business rules and determines if the mail is valid. It allowas to plug in new rules easily.

I'm not taking into account database access, but it can be done by injecting the repository classes with Dependency Injection.

The use of interfaces and clean separation of concerns makes them easily testable, maintanable and extensible.
