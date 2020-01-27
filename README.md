# Inventory Project

Create an application to manage an inventory of products. To start with the application need to be able to store CDs and books and save them to an XML document.

Application Design
Classes: Main, StoreManager, CDProduct, BookProduct, PersistentStore
Abstract classes: Product, Store
Interface: StorageCapable
The Main class is responsible for starting the application. It create a StoreManager instance to be able to store products.

The StoreManager to work correctly need to be provided with a StorageCapable instance via the addStorage method. After this is done we can use it to add and store products. E.g. calling the addCDProduct method with the correct arguments from the main method will store a CD product in the underlying storage facility. In the implementation of the addCDProduct call the storeCDProduct method on the StorageCapable instance that was previously added to the StoreManager.

The Store class is abstract. The store method accepts a Product instance as its parameter, which product is created via the createProduct method. createProduct is implemented in the Store class and the concrete product creation (BookProduct or CDProduct) depends on the type parameter. It can be "CD" or "Book".

The store method calls the saveToXml method and the storeProduct method. The store method implements a pattern called the Strategy Pattern. It means the execution strategy (calling saveToXml and storeProduct ) is fixed even if you inherit from this class.

The saveToXml method is implemented in the Store abstract class. Calling it saves the incoming product to XML.

The PersistentStore extends the Store class and implements the storeProduct method. When called the incoming product is stored in memory (in a list, or array for example).

A StorageCapable instance is able to retrieve all products as list of product instances ( List ). Based on it the StoreManager can calculate the total price and display the name of the stored products.

Getters and setters are omitted: create them when necessary; otherwise don't.

The UML diagram is not complete. If you think there needs to be other methods, feel free to create ones, add exception classes, etc. Feel free to experiment.

