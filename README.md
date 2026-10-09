# GEDAI_Midterm
PART 1 : Low Fidelity Prototype 
The game I was tasked with was Bubble Bobble. See below a screenshot of both Level 1 and Level 2.
I was able in the time to make the player controller with jumping and horizontal movement with the help of boilerplate code I had. Bubbles were prefabbed but not implemented due to time constraints, enemies where not implemented. 

<img width="315" height="176" alt="Screenshot 2026-10-08 211418" src="https://github.com/user-attachments/assets/a7099de4-48d4-44b5-ad1b-5c5e15650660" />
<img width="314" height="176" alt="Screenshot 2026-10-08 220347" src="https://github.com/user-attachments/assets/d5be041d-2dff-4547-99ac-53dbe557caa4" />

Given the time limited I wanted to focus on general silhouette of the level and not looks. Because I didn't plan on using enemies for the singleton or factory pattern they were an oversight on my part not adding them as decoration/additional gameplay.


PART 2 - Object Oriented Programming

I used inheritance, abstraction and encapsulation within in my project. 

Inheritance example: 

<img width="206" height="38" alt="Screenshot 2026-10-08 211521" src="https://github.com/user-attachments/assets/297b8f6b-e953-4055-8c7e-9dcbeedd62ed" />

I made it so my singleton was a base class that other scripts could inherit from. My Script “SceneSwitcher” inherits from the singleton class in order for it to be a singleton with being filled with the singleton code. This also makes the code much more modular to use on other singletons in the future. 


Abstraction Example:

I used abstraction within my Factory to make it an abstract class that other factory scripts could inherit from and override. The Factory class is abstract and has the method GetBubble(Vector3 position), this was than planned to be inherited by BubbleFactoryA where GetBubble(Vector3 position) would be overriden to create a prefabbed instance of the bubble (bubble specific to the factory if multiple)

<img width="211" height="38" alt="Screenshot 2026-10-08 211853" src="https://github.com/user-attachments/assets/f62181e5-37de-4f13-a8ce-2762e71ce8cf" />
<img width="752" height="365" alt="Screenshot 2026-10-08 212330" src="https://github.com/user-attachments/assets/126ac36c-2e84-4923-a76a-6a0d63b0f895" />

NOTE due to errors in code, even with commenting out functionality, the game was not going to build with BubbleFactoryA therefore it was deleted. The code is still visible within the FinalGamePush commit as a deleted script.


Encapsulation Example:

<img width="176" height="73" alt="Screenshot 2026-10-08 212752" src="https://github.com/user-attachments/assets/1fea1361-8f37-43fb-8ab3-f0a966a8f443" />

All throughout my project I used access modifiers to keep the code clean and only seen when necessary to modify it. Public when I want to modify within the inspector window, private when I dont need it to be accessable elsewhere.


PART 3 - Singleton Pattern

For my implementation for the Singleton Pattern I planned on making a Scene Switcher. Although the code for the Scene Switcher is unfunctional the core Singleton Pattern is still evident in my code. Bubble Bobble deals with a lot of scene changes, with many scene changes I felt it important to make sure there was never more than one scene switcher manager, hence making it into a singleton. 

<img width="234" height="182" alt="Screenshot 2026-10-08 213045" src="https://github.com/user-attachments/assets/1d5bdaba-7729-4027-af18-ca9c9c668a5f" />
<img width="317" height="184" alt="Screenshot 2026-10-08 213109" src="https://github.com/user-attachments/assets/36bfce72-7d2e-45e9-a08c-b8f3c2c9b01d" />
<img width="231" height="80" alt="Screenshot 2026-10-08 213152" src="https://github.com/user-attachments/assets/041b0f3c-205e-4d7b-8712-3014aeef5891" />

If properly implemented the Scene Switcher would switch scenes every time the player collides with an object tagged with “Switch” going back and forth between the 2 levels created. The SceneSwitcher inherits its singleton attributes from the Singleton base class and the SceneSwitcher stores the changing logic. The SceneSwitcher is than called in the PlayerController when they collide with tag “Switch” to complete the CheckandLoad() method. 

PART 4 - Factory Pattern
For the factory pattern I planned on using it for spawning in different kinds of bubbles that are used in the game; be an overall bubble creator and manager. Due to bugs and errors I couldn't figure out within the time frame, this code did not become functional, however I will explain in detail what the code would've done had it been.

<img width="240" height="71" alt="Screenshot 2026-10-08 215653" src="https://github.com/user-attachments/assets/1f352a5d-f469-42d0-9c32-049ae3cab174" />
<img width="203" height="169" alt="Screenshot 2026-10-08 215834" src="https://github.com/user-attachments/assets/f300933e-0dc3-45be-ae89-023cc6ed5560" />
<img width="137" height="50" alt="Screenshot 2026-10-08 215924" src="https://github.com/user-attachments/assets/333baa92-1e20-4736-9472-af70e587842b" />
<img width="752" height="365" alt="Screenshot 2026-10-08 212330" src="https://github.com/user-attachments/assets/45c7c554-e7eb-45b5-83b2-c6dda069d3d1" />
<img width="167" height="60" alt="Screenshot 2026-10-08 215950" src="https://github.com/user-attachments/assets/657c96e7-bac5-4e3b-9073-0e06f256c46d" />


For starters I created an IBubble interface to hold the Initialization method for later use. Next the Factory was made as an abstract class with an abstract GetBubble(Vector3 position) that is overridable for other Factories. BubbleFactoryA would've inherited from Factory, this is were the GetBubble method would've been overridden in order to create an instance of a bubble in a certain position, Inheriting information needed in BubbleA. Then finally the Bubble Manager would spawn the bubble using the factory and the BubbleA attributes. 

Reflection:
I have realized my biggest mistake was with how I set up and used my Boilerplates. I used several resources provided in lecture and tutorial to create boilerplates for Factory and Singleton. In theory this should've made this midterm much easier, but when modifying them to do extra things and changing the variable names to be more cohesive with the game, it got confusing and messy to figure out where everything was and what needed to be added/fixed/modified. I do think I could've made one of the two functional with more time in the midterm, but overall I feel like i understand the overarching concepts and need to focus more on implementation when studying towards the final exam.

