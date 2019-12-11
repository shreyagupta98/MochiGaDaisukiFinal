# Game Basic Information #

## Summary ##

**A paragraph-length pitch for your game.**

## Gameplay explanation ##

**In this section, explain how the game should be played. Treat this as a manual within a game. It is encouraged to explain the button mappings and the most optimal gameplay strategy.**

Our gameplay is relatively simple. Through progressing through choices, you want to get to the end goal of finishing the story and seeing it to the end. 

Right arrow key and enter allows you to progress the dialogue box. 

Use your mouse to pick choices. 

Press 'S' to save the game and reopen the game on the spot you left off. 


# Main Roles #

Your goal is to relate the work of your role and sub-role in terms of the content of the course. Please look at the role sections below for specific instructions for each role.

Below is a template for you to highlight items of your work. These provide the evidence needed for your work to be evaluated. Try to have at least 4 such descriptions. They will be assessed on the quality of the underlying system and how they are linked to course content. 

*Short Description* - Long description of your work item that includes how it is relevant to topics discussed in class. [link to evidence in your repository](https://github.com/dr-jam/ECS189L/edit/project-description/ProjectDocumentTemplate.md)

Here is an example:  
*Procedural Terrain* - The background of the game consists of procedurally-generated terrain that is produced with Perlin noise. This terrain can be modified by the game at run-time via a call to its script methods. The intent is to allow the player to modify the terrain. This system is based on the component design pattern and the procedural content generation portions of the course. [The PCG terrain generation script](https://github.com/dr-jam/CameraControlExercise/blob/513b927e87fc686fe627bf7d4ff6ff841cf34e9f/Obscura/Assets/Scripts/TerrainGenerator.cs#L6).

You should replay any **bold text** with your relevant information. Liberally use the template when necessary and appropriate.

**MOST OF OUR GAME CAME FROM STELLAR STUDIOS! [https://www.youtube.com/watch?v=nnxZVU0qe5I&list=PLGSox0FgA5B7mApF1vhbspLj5NpzKedU6]**

**We followed all of his tutorials and essentially went through each script and video to generate the game we have currently. Because of the "simplicity of a visual novel," many of our roles ended up blending in with each other as well as all of us contributing to different parts of the game. For example, our script required work from all of us. In order for us to understand how commands are separated, we all had to go through the script video and watch how the game script is essentially written out. There are plenty more examples we can list but this is a general disclaimer that all of our grades should be combined instead of being separated into different roles.** 

## User Interface

**Describe your user interface and how it relates to gameplay. This can be done via the template.**

*Dialogue System* - The controls for the dialogue box is mostly controlled via DialogueSystem.

[Say simply projects the line of dialogue.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/DialogueSystem.cs#L21)

[StopSpeaking helps to determine when a user has stopped speaking.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/DialogueSystem.cs#L31)
[DetermineSpeaker determines who the speaker is based on which is obtained in the character system.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/DialogueSystem.cs#L89) It also separated narrator from characters so that way, we do not have the name box open whenever the narrator is saying something. 

*NovelController* - Most of our dialogue logics and commands however are read in text files. 
[Most of these text files are essentially parsed in the NovelController, where it determines our various commands and differentiates them from regular dialogue.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/Novel%20Controller/NovelController.cs#L5) For example:

enter(Kuma) next

Kuma "This is what it means to be a Kuma"

exit(Kuma) next

These lines can easily be parsed into "commands" such as enter and exit as well as a next that loads our next line without needing the user to put an extra input, with the second line being the dialogue that will be shown in our dialogue box. 

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

*AudioManager* - Our Audio is all generated in AudioManager. 
[PlaySong controls all our currently playing songs.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/d7676bca6b05be1e9b6415331422d4c40b066bec/Mochi/Assets/Scripts/Core/AudioManager.cs#L40) The small little caviat here is that we made a function that helps to handle the transition of music and keep it playing at the same part it last left off. 

[PlaySFX controls our sound effects.](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/d7676bca6b05be1e9b6415331422d4c40b066bec/Mochi/Assets/Scripts/Core/AudioManager.cs#L29)

A lot of our music was pulled off bigger games.

- Our Arcade scene music originated from Maplestory, a game developed by Nexon and Wizet
[https://www.youtube.com/watch?v=mD2b0Xx7wPA]

- Our home scene/interlude between the bicycle and the arcade scene music came from Undertale, a game by Toby Fox 
[https://www.youtube.com/watch?v=lsoLYWTzqSY]

- Our Bicycle scene included music ffrom GRISAIA NO MEIKYUU, a light novel series made by FRONTWINGS
[https://www.youtube.com/watch?v=j4ID0Ex56Qc]

- Our Police Scene sounds come from FFVII, owned by Square Enix, and InitialD by STUDIO COMET/GALLOP 
[https://www.youtube.com/watch?v=atuFSv2bLa8]
[https://www.youtube.com/watch?v=t7wJ8pE2qKU]

- Our Mystery theme/Muma theme came from Bleach, animated by Studio Pierrot
[https://www.youtube.com/watch?v=e4R9pYcl3xM]

All of our SFX are mostly free except for the exception:

- The Iphone ring tone used for Muma's phone
[https://www.youtube.com/watch?v=VDvFcn6icXo]


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

To improve the game feel, we collectively suggested and made minor changes to improve various elements that players generally focus on in visual novels like tweaking the text font and size to increase readability. 
The fade in and out transitions were also tweaked. Some sound effects were changed as well. 

All of these improvements fuel the overall impact that the game leaves on the player while playing.
