# Practice_Encapsulation

This project demonstrates the concept of encapsulation in C# using a `Car` class. The example includes properties, encapsulation, and basic validation with informative error messages.

## Class: Car

### Properties
- **`Brand`**: Stores the brand of the car as a string.
- **`Model`**: Stores the model of the car as a string.
- **`Color`**: Stores the color of the car as a string.
- **`DoorCount`**: Stores the number of doors. Encapsulated to only accept valid values (2 or 4). If an invalid value is assigned, it defaults to `-1` and displays a warning.

### Methods
- **`CarInfo()`**: Prints the car's details (brand, model, color, and door count). If the `DoorCount` is invalid, it also displays a warning message.
  
## Sample Output
![image](https://github.com/user-attachments/assets/8838ac67-cbe4-4e5c-a111-03caa9ebb332)
