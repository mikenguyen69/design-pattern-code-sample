# design-pattern-code-sample
A repository contain all popular 23 GoF design patterns implementation and real life examples. It aims to demonstrate the practical of TDD when implementing the design patterns ;). Two Best of both Dev Worlds 

## Structure Patterns
### S1. Proxy 
Provide a place holder for another object so as to control access to it 
The proxy can be implented as interface or concrete class and it must containg the pointer to all sub systems that we expected to be represented. 

### S2. Flyweight
Serve a large number of request for an object by sharing its existing instance. 
FlyweightFactory should know its flywieght instance state hence first look for un-used object else created the new one
