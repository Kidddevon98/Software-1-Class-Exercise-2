# Software 1 - Class Exercise 2

## Goals
- Learn how to use the 2 most commonly used collections: List and Dictionary.

## Instructions
In the last exercise we added a function to add a product to store. In this exercise, we're going to expand on that as well as add a new function to view our product list.

### Steps Completed
1. Added a new class `ProductLogic` to handle all of our product functionality.
2. Created a private variable called `_products` of type `List<Product>` in `ProductLogic`.
3. Implemented methods `AddProduct` and `GetAllProducts` in `ProductLogic`.
4. Added private variables for dictionaries to store `DogLeash` and `CatFood` products.
5. Added methods to handle product-specific logic and retrieval.
6. Updated the `Program` class to interact with `ProductLogic`.

## Usage
- Run the application using `dotnet run`.
- Follow the console prompts to add or view products.

## Example Interaction
```plaintext
Press 1 to add a product
Press 2 to view a dog leash by name
Type 'exit' to quit
1
Enter the type of product (catfood or dogleash): dogleash
Enter Name: Red Leash
Enter Price: 19.99
Enter Quantity: 10
Enter Description: A strong red leash
Enter Length (inches): 60
Enter Material: Nylon
Dog leash added successfully.
