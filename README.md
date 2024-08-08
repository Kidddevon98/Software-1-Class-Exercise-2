# Software 1 - Class Exercise 2

## Goals

- Learn how to use the 2 most commonly used collections: List and Dictionary.

## Instructions

In this exercise, we added a function to add a product to the store and a function to view our product list.


## Classes

### Product
Represents a generic product with the following properties:
- `Name`: string
- `Price`: decimal
- `Quantity`: int
- `Description`: string

### CatFood
Inherits from `Product` and adds:
- `KittenFood`: bool

### DogLeash
Inherits from `Product` and adds:
- `LengthInches`: int
- `Material`: string

### ProductLogic
Handles product-related functionality:
- Stores a list of products.
- Stores dictionaries for `DogLeash` and `CatFood`.
- Methods to add products and retrieve them.

## How to Run

1. **Build the Project**:
   - Open a terminal and navigate to the `StoreApp` directory.
   - Run `dotnet build`.

2. **Run the Application**:
   - In the terminal, run `dotnet run`.

3. **Interact with the Application**:
   - Follow the prompts to add products or view a dog leash by name.
   - Press `1` to add a product.
   - Press `2` to view a dog leash by name.
   - Type 'exit' to quit the application.
