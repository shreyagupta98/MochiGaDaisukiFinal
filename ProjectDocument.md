# Game Basic Information #

## Summary ##

**A paragraph-length pitch for your game.**

## Gameplay explanation ##

**In this section, explain how the game should be played. Treat this as a manual within a game. It is encouraged to explain the button mappings and the most optimal gameplay strategy.**




# Main Roles #

Your goal is to relate the work of your role and sub-role in terms of the content of the course. Please look at the role sections below for specific instructions for each role.

Below is a template for you to highlight items of your work. These provide the evidence needed for your work to be evaluated. Try to have at least 4 such descriptions. They will be assessed on the quality of the underlying system and how they are linked to course content. 

*Short Description* - Long description of your work item that includes how it is relevant to topics discussed in class. [link to evidence in your repository](https://github.com/dr-jam/ECS189L/edit/project-description/ProjectDocumentTemplate.md)

Here is an example:  
*Procedural Terrain* - The background of the game consists of procedurally-generated terrain that is produced with Perlin noise. This terrain can be modified by the game at run-time via a call to its script methods. The intent is to allow the player to modify the terrain. This system is based on the component design pattern and the procedural content generation portions of the course. [The PCG terrain generation script](https://github.com/dr-jam/CameraControlExercise/blob/513b927e87fc686fe627bf7d4ff6ff841cf34e9f/Obscura/Assets/Scripts/TerrainGenerator.cs#L6).

You should replay any **bold text** with your relevant information. Liberally use the template when necessary and appropriate.

## User Interface

**Describe your user interface and how it relates to gameplay. This can be done via the template.**
The controls for the dialogue box is mostly controlled via DialogueSystem.
[Say simply projects the line of dialogue.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/DialogueSystem.cs#L21)
[StopSpeaking helps to determine when a user has stopped speaking.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/DialogueSystem.cs#L31)
[DetermineSpeaker determines who the speaker is based on which is obtained in the character system.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/DialogueSystem.cs#L89)

Most of our dialogue logics and commands however are read in text files. 
[Most of these text files are essentially parsed in the NovelController, where it determines our various commands and differentiates them from regular dialogue.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/Novel%20Controller/NovelController.cs#L5)

## Movement/Physics

**Describe the basics of movement and physics in your game. Is it the standard physics model? What did you change or modify? Did you make your movement scripts that do not use the physics system?**

## Animation and Visuals

**List your assets including their sources and licenses.**

**Describe how your work intersects with game feel, graphic design, and world-building. Include your visual style guide if one exists.**

## Input

**Describe the default input configuration.**

**Add an entry for each platform or input style your project supports.**

## Game Logic

**Document what game states and game data you managed and what design patterns you used to complete your task.**

# Sub-Roles

## Audio

**List your assets including their sources and licenses.**

**Describe the implementation of your audio system.**

**Document the sound style.** 

## Gameplay Testing

**Add a link to the full results of your gameplay tests.**

**Summarize the key findings from your gameplay tests.**

## Narrative Design

**Document how the narrative is present in the game via assets, gameplay systems, and gameplay.** 

## Press Kit and Trailer

**Include links to your presskit materials and trailer.**

**Describe how you showcased your work. How did you choose what to show in the trailer? Why did you choose your screenshots?**



## Game Feel

**Document what you added to and how you tweaked your game to improve its game feel.**
