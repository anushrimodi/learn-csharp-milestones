# C# Unity Milestones

Below is a list of tasks that correspond roughly to the "Take Action" sections of [Learning C# by Developing Games with Unity](https://www.packtpub.com/product/learning-c-by-developing-games-with-unity-seventh-edition/9781837636877) by Harrison Ferrone. By mid-semester, everyone should...

- Understand what the task is asking
- Be able to do the task
- Make it clear through your actions you understand what's happening



## Contents

1. [Instructions](#Instructions)
1. [Chapter 1](#chapter-1) - Getting to Know Your Environment (9–21)
1. [Chapter 2](#chapter-2) - The Building Blocks of Programming (22–37)
1. [Chapter 3](#chapter-3) - Diving into Variables, Types, and Methods (38–64)
1. [Chapter 4](#chapter-4) - Control Flow and Collection Types (65–93)
1. [Chapter 5](#chapter-5) - Working with Classes, Structs, and OOP (94–119)
1. [Chapter 6](#chapter-6) - Getting Your Hands Dirty with Unity (120–148)
1. [Chapter 7](#chapter-7) - Movement, Camera Controls, and Collisions (149–175)
1. [Chapter 8](#chapter-8) - Scripting Game Mechanics (176–207)






## Instructions

1. Fork this repository (into your own Github account)
1. Complete each task below inside this sample project (the project is the repository)
1. Check off each task as you complete it, creating files and adding content where prompted with ✏️ or  **??**
1. Commit and push your work after each chapter
1. After you finish, celebrate your C# proficiency! 🙌


#### Notes...

- **RTM** - Sometimes I give the command you need and sometimes you have to read the documentation to find it.
- **Details** - Following the instructions, especially those with a ✏️
- **Reference** - If you get stuck compare your code with the book [source code](https://github.com/PacktPublishing/Learning-C-8-by-Developing-Games-with-Unity-2020)






## Chapter 1
Getting to Know Your Environment (9–21)

- [X] ✏️ Open the reference manual for any component from inside Unity. Paste the link: file:///Applications/Unity/Hub/Editor/6000.2.2f1/Documentation/en/ScriptReference/MonoBehaviour.html
- [X] ✏️ Find the button to jump to the scripting reference the any reference manual page. Paste the link: file:///Applications/Unity/Hub/Editor/6000.2.2f1/Documentation/en/ScriptReference/index.html
- [X] ✏️ Search for the `Strings` class in [Microsoft's C# documents](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/). Paste the link: https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-9.0


## Chapter 2
The Building Blocks of Programming (22–37)

- [X] Open the Unity project contained within this repo
- [X] Create Assets/Scripts/LearningCurve.cs
	- [X] Create C# variables with typeof `int`, `float`, `string`, and `bool`
	- [X] Add a single line, multi line, and summary comment to LearningCurve.cs
	- [X] Run the code in LearningCurve by attaching it to the Main Camera GameObject


## Chapter 3
Diving into Variables, Types, and Methods (38–64)

- [X] Update Assets/Scripts/LearningCurve.cs
	- [X] Variables
		- [X] Use access modifiers to make your variables explicitly `public` and `private`
		- [X] Use `Debug.Log` and `Debug.LogFormat` to log your variables to the console
		- [X] Concatenate strings using the `+` operator, and the string interpolation method `$`
	- [X] Methods
		- [X] Define a simple method with parameters
		- [X] Add a return type and return some data from a method
		- [X] Use data returned from a method
- [X] ✏️ Explain some differences between public and private variables: **Public variables** are visible in Inspector and we can see and change them in Unity’s Inspector window. We can access public variables everywhere: other scripts can read and change them. **Private variables** are hidden in Inspector and we can’t see them in Unity’s Inspector. We can only use them inside the script and other scripts can’t touch them, only the script that owns them can.


## Chapter 4
Control Flow and Collection Types (65–93)

- [X] Update Assets/Scripts/LearningCurve.cs
	- [X] Conditionals
		- [X] Write `if`, `else if`, and `else` statements
		- [X] Test for `true` and `!true` in a conditional
		- [X] Write a nested `if` statement
		- [X] Write a `switch` statement
	- [X] Collections
		- [X] ✏️ What will `arr[1]` return from this array `int[] arr = {'red','green','blue'};` ? : **green**
		- [X] Write an Array of the type `int[]`
		- [X] Write a List of the type `List<string>`
		- [X] Write a Dictionary of the type `Dictionary<string, int>`
	- [X] Loops
		- [X] Use a `for` loop to print a specific index of a `List<string>`
		- [X] Use a `foreach` loop to print all indexes of a `List<string>`
		- [X] Use a `foreach` loop to print the `KeyValuePair.Key` and `KeyValuePair.Value` of all indexes of a `Dictionary<string, int>`



## Chapter 5
Working with Classes, Structs, and OOP (94–119)

- Classes
	- [X] ✏️ Explain the difference between reference and value type variables: **Value types** (int, float, bool) store the data itself. Assigning or passing them copies the value. If we change the copy, it doesn’t affect the original. **Reference types** (classes, arrays) store a reference (pointer) to data on the heap. Assigning or passing them copies the reference, so multiple variables can refer to the same underlying object; if we change it via one reference, it is seen by all.
	- [X] Create Assets/Scripts/Character.cs
		- [X] Create a `Character` class
		- [X] Create `string` and `int` fields inside the Character class
		- [X] Create a `Character()` constructor and populate the above fields with its parameters
	- [X] Update Assets/Scripts/LearningCurve.cs
		- [X] Instantiate two new Character objects `hero` and `heroine` from the `Character` class
		- [X] Print out each characters data
- [X] Structs
	- [X] Update Assets/Scripts/Character.cs
		- [X] Add a `Weapon` struct
		- [X] Create `string` and `int` fields inside the Weapon struct
		- [X] Create a `Weapon()` constructor and populate the above fields with its parameters
	- [X] Update Assets/Scripts/LearningCurve.cs
		- [X] Instantiate two new Weapon objects `huntingBow` and `warBow` from the `Weapon` struct
		- [X] Print out each weapons' data
- Child classes
	- [X] Update Assets/Scripts/Character.cs
		- [X] Add a `Paladin` child class of `Character`
		- [X] Create a `Weapon` field inside the Paladin class
		- [X] Create a `Paladin()` constructor that calls the `base()` constructor. Populate the weapon in a parameter
	- [X] Update Assets/Scripts/LearningCurve.cs
		- [X] Instantiate a new Paladin object `knight` from the Paladin class
		- [X] Print the Paladin's name and weapon by overriding `PrintStatsInfo` in the base class
- Referencing objects
	- [X] Update Assets/Scripts/LearningCurve.cs
		- [X] Store a reference to the current game object's (Main Camera) `Transform` component using `GetComponent<>()`
		- [X] Log a reference to the `localPosition` field of the Main Camera's `Transform`
		- [X] Store a reference to the Light `GameObject` using `GameObject.Find()`
		- [X] Store a reference to the Light's `Transform` component using `GetComponent<>()`
		- [X] Log a reference to the `localPosition` field of the Light's `Transform`



## Chapter 6
Getting Your Hands Dirty with Unity (120–148)

- [X] Use primitive cubes and move, rotate, and scale tools to create a level or "world" in Unity
- [X] Add materials to primitives in Unity to change their color
- [X] Use parenting and "empty objects" in the Hierarchy tab to organize your project
- [X] Create, update, and use prefab game objects
- [X] Create timeline animations by recording keyframes and editing curves in Unity
- [X] Add and edit a particle system to a game object in Unity




## Chapter 7
Movement, Camera Controls, and Collisions (149–175)

- [X] Movement
	- [X] Understand the difference between a "position vector" and a "direction vector"
	- [X] Capture keyboard input in C#
	- [X] Move and rotate a game object using `Translate()` and `Rotate()` with direction vectors
- [X] Camera Controls
	- [X] Add a script to the main camera that follows and looks at the player
- [X] Physics and Collisions
	- [X] Use `FixedUpdate()` to control game objects using Unity's physics engine
	- [X] Apply physics forces to a game object RigidBody using `MovePosition()`
	- [X] ✏️ Q: Will a [collision detection](https://docs.unity3d.com/Manual/CollidersOverview.html) occur when a Kinematic Rigidbody Collider touches a Static Collider? : **Yes**
	- [X] Use `OnCollisionEnter()` to check if a game object has run into another collider
	- [X] Use `Destroy()` to remove a game object from the scene
	- [X] Use `OnTriggerEnter()` and `OnTriggerExit()` to detect when two colliders start and stop touching





## Chapter 8
Scripting Game Mechanics (176–207)

- Character Control
	- [X] Capture keyboard input in C# using the `enum` type and value `KeyCode.Space`
	- [X] Use `AddForce()` to make a character jump
	- [X] Use a `LayerMask` and a new "Ground" layer in Unity to determine if a character is "IsGrounded"
- [X] Add a shooting mechanic
	- [X] Create a "projectile" prefab that moves forward using `RigidBody.velocity`
	- [X] Instantiate the projectile on click and destroy it after `3` seconds
- [X] Create a GameManager
 	- [X] Use `get` and `set` properties to return and assign properties that are used across the game
- [X] Add a simple UI to inform the user of game state(s)
	- [X] Add text to show the health and items counts to the user
	- [X] Add a win condition to the game and display it in the UI
	- [X] Use `Time.timeScale = 0` to pause the game
