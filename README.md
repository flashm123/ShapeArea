# ShapeArea
The library to find area of the shape. 

It takes the shape parameters on input and provides the client with the area on the output:

![image](https://user-images.githubusercontent.com/59667317/117050780-6fb9be00-ad1e-11eb-9169-5e557ad18ade.png)


This library is used to find the area of the shapes. I've tried to make architecture flexible to add new shapes using SOLID practice. 

We use Factory Method to receive the concrete shape and Builder pattern to "build" the shape. 

The client works with the interface - clean contract that allows him to get the area. He "doesn't know" about the type of the shape and about interface.

The project contains auto tests.
