# design-pattern-code-sample
A repository contain all popular 23 GoF design patterns implementation and real life examples. It aims to demonstrate the practical of TDD when implementing the design patterns ;). Two Best of both Dev Worlds 

## Structure Patterns
### S1. Proxy 
Provide a place holder for another object so as to control access to it 
The proxy can be implented as interface or concrete class and it must containg the pointer to all sub systems that we expected to be represented. 

### S2. Flyweight
Serve a large number of request for an object by sharing its existing instance. 
FlyweightFactory should know its flywieght instance state hence first look for un-used object else created the new one

### S3. Proxy
Proxy allow access to target objet hence want to route all calls through a placeholders. It hides creation of configuration process of the target object from the client due to complexity involved. It also dynamically change the target object without affecting client code. Target objet is not going to be available at the dev time, it provides option for your to connect to the target only at run time. 

### S4. Adapter
Adapter is used when new class has incompatible design comparing to the existing one. Hence the adapter is used to convert the interfaces of the existing class into another interface as expected by client app

### S5. Bridge
All software version shouldn't be broken or altered its behaviour upon adding any new release if they are actively being used by client. Hence bridge enable a way to implement change across different versions. 

### S6. Composite
Composite allows to create data in a tree structure that a single item and a group of item from the tree can be treated in uniform manner.

### S7. Decorator 
Decorator add extra funcitonality to an object dynamically. 
