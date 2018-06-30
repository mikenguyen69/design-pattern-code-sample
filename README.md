# design-pattern-code-sample
A repository contain all popular 23 GoF design patterns implementation and real life examples 

## Structure Patterns
### S1. Proxy 
Provide a place holder for another object so as to control access to it 
The proxy can be implented as interface or concrete class and it must containg the pointer to all sub systems that we expected to be represented. 

### S2. Facade
Serve a large number of request for an object by sharing its existing instance. 
The Flyweight should contain state in which it could be used or freeup upon used. FlyweightFactory should first look for un-used object else created the new one
