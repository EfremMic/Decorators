
<details open>
  <summary>Detail</summary>

  <p># Decorator Design Pattern in C#

This repository showcases the Decorator Design Pattern implemented in C#. The Decorator pattern is a structural design pattern that allows you to attach additional responsibilities to an object dynamically. It provides a flexible and clean way to extend the behavior of objects without altering their code.

## Overview

In this repository, you will find:

- `Component` interface: Defines the base component interface that concrete components and decorators will implement.
- Concrete component class: Represents the core object to which decorators can be attached.
- `Decorator` class: Serves as the base class for all decorators, implementing the `Component` interface.
- Concrete decorator classes: Implement specific behaviors and add functionalities to the core component.

## Usage

You can use the Decorator pattern to enhance the behavior of objects in a flexible and reusable way. Here's an example of how to use the Decorator pattern:

```csharp
// Create a core component (e.g., a simple text component)
Component textComponent = new TextComponent("Hello, World!");

// Wrap it with decorators to add extra functionality
Component decoratedComponent = new BoldDecorator(new ItalicDecorator(textComponent));

// Call operations on the decorated component
string result = decoratedComponent.Render();
Console.WriteLine(result);
</p>

  
  <ul dir="auto">
    <pre> <h4> PizzaConstractor-With Decorators </h4></pre>
    <li><a href="https://github.com/EfremMic/Decorators/tree/PizzaConstractorWithDecorators/PizzaConstractor">PizzaConstractorWithDecorator</a></li>
  </ul>
</details>
