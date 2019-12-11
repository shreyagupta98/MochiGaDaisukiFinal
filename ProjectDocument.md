# Game Basic Information #

## Summary ##

Mochi Ga Daisuki is a fun and light-hearted visual novel experience inspired by the daily anxieties faced by college students in Davis. The story revolves around you, Ushi, a young and energetic (and slightly vulgur) UC Davis student determined to complete a task assigned by your CS professor, Kuma, in order to achieve the full level of happiness = a life's worth of mochi. Stay safe on the road, make decisions based on your personality, and find the quickest and safest route to the mochi festival BEFORE time runs out!

## Gameplay explanation ##

**In this section, explain how the game should be played. Treat this as a manual within a game. It is encouraged to explain the button mappings and the most optimal gameplay strategy.**

Our gameplay is relatively simple. Through progressing through choices, you want to get to the end goal of finishing the story and seeing it to the end. 

Right Arrow key, space, Left Mouse click, and enter allows you to progress the dialogue box. 

Use your mouse to pick choices. 

Press 's' to save the game and reopen the game on the spot you left off. 


# Main Roles #

Your goal is to relate the work of your role and sub-role in terms of the content of the course. Please look at the role sections below for specific instructions for each role.

Below is a template for you to highlight items of your work. These provide the evidence needed for your work to be evaluated. Try to have at least 4 such descriptions. They will be assessed on the quality of the underlying system and how they are linked to course content. 

*Short Description* - Long description of your work item that includes how it is relevant to topics discussed in class. [link to evidence in your repository](https://github.com/dr-jam/ECS189L/edit/project-description/ProjectDocumentTemplate.md)

Here is an example:  
*Procedural Terrain* - The background of the game consists of procedurally-generated terrain that is produced with Perlin noise. This terrain can be modified by the game at run-time via a call to its script methods. The intent is to allow the player to modify the terrain. This system is based on the component design pattern and the procedural content generation portions of the course. [The PCG terrain generation script](https://github.com/dr-jam/CameraControlExercise/blob/513b927e87fc686fe627bf7d4ff6ff841cf34e9f/Obscura/Assets/Scripts/TerrainGenerator.cs#L6).

You should replay any **bold text** with your relevant information. Liberally use the template when necessary and appropriate.

## DISCLAIMER + MAIN ROLE BREAKDOWN

**MOST OF OUR GAME CAME FROM STELLAR STUDIOS! [https://www.youtube.com/watch?v=nnxZVU0qe5I&list=PLGSox0FgA5B7mApF1vhbspLj5NpzKedU6]**

- We followed all of his tutorials and essentially went through each script and video to generate the game we have currently. Because of the "simplicity of a visual novel," many of our roles ended up blending in with each other as well as all of us contributing to different parts of the game. For example, our script required work from all of us. In order for us to understand how commands are separated, we all had to go through the script video and watch how the game script is essentially written out. There are plenty more examples we can list but this is a general disclaimer that all of our grades should be combined instead of being separated into different roles.

- Below will be a list of what we did a lot on (but to be fair, a lot of us crossed over to help each other to understand what to do)

**BREAKDOWN** 

- Jesse: Scripting(Translating from Story Script to Game Script, also helped create some scenes(Police Scene!)), UI(Understood how to parse game script to dialogue + different commands) + Game Logic(Created commands to help progress story when items loaded in) + Audio(Found a bulk of the music for the game) 

- Shreya: [Animation & Visual](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/master/ProjectDocument.md#animation-and-visuals) + [Press Kit & Trailer](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/master/ProjectDocument.md#press-kit-and-trailer)

- Ajay: Scripting(Translating story to fit game's narrative, also helped create some scenes(Muma mugging scene) among others), Movement(Utilized necessary transition scripts to refine movements) + Audio(Helped search for appropriate,scene-fitting audio pieces) + Game Feel(Tweaked the game's features and added juice)

- Eshan: Designing and scripting the Main Menu page + Game Logic (main role) + Audio (helped searching for sound effects and background music) + Images for the backdrops + Testing (sub-role) + UI

- All our subroles are defined but playtesting fell under more than just one person's role.


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

[More of our commands can be found in the text document](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/master/Mochi/Assets/Resources/Story/Commands.txt#L1) Some were not used as we got used to only using some of the commands and not all of them.

[*Most if not all of the assets used for our UI were from StellarStudio's Assets that we pulled from his project or from this tumblr link*](https://visual-novel-interfaces.tumblr.com/resources)


The title page has 3 buttons - New Game, Load Game, and Exit. Since our game can only save 1 file, the "New Game" button will delete the current/saved game and the "Load Game" button will load the existing saved game. The "Exit" button will quit the application if it is built or change EditorApplication.isPlaying = false if the game is in editor mode. 

## Model Movement in Visual Novel

Due to nature of visual novels, there are elements like physics are essentially non-existent in such a medium. However, there is definitely movement present in the form of object and character animations and expressions to complement each point in the story, scene transitions to indicate the player's presence in and between scenes.

*TransitionMaster* - Handles the transition from image to appear and vice-versa.
[This method deals with the execution of most transitions](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/TransitionMaster.cs#L47)

*TitleHeader* - The fade transitions for the title box.
[TitleHeader has these types of fade transitions to choose from](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/InputAndChoiceSystem/TitleHeader.cs#L13)

*ChoiceScreen* - To present the choices on screen
[Lists out the available choices](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/InputAndChoiceSystem/ChoiceScreen.cs#L71)

*Character* - To move the character's positions
[Deals with the character movement across the screen](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/Character.cs#L97)

*Character* - To change the character's expressions
[This function render the character's expressions with the sprites](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/7d52132f2f44a14f23125aa2ca41a4704d5df5e2/Mochi/Assets/Scripts/Core/Character.cs#L234)

## Animation and Visuals

Epilogue backdrop: http://thecoter.ie/tag/shop/

Mochi: https://www.wholefoodsmarket.com/blog/trending-whole-foods-market-mochi

Character:

![Image of Characters](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/master/title.png)

With a clear idea of what we wanted the main characters in the story to look like, we decided to use original assets to portray the story. We drew characters from scratch using Procreate, pulling inspiration from We Bare Bears. The genre of the game was a comedy visual novel in which the characters used amusing and light-hearted conversations to uplift the player and keep them engaged. In bringing the character of Professor Kuma to life, the main idea was to create a soft, almost plushie-like character to support the narrative and attract our target audience of college students. In building the world, we based the smaller role characters off of Kuma's form to maintain consistency and focused on the design of the characters' expressions and clothing to differentiate their roles.

World:

![Image of Backdrops](https://github.com/shreyagupta98/MochiGaDaisukiFinal/blob/master/Mochi/Assets/Resources/Images/UI/backdrops/arcade.png)

As our audience was 100% Davis mochi lovers, it was important for us to maintain the image of Davis in the game while also providing a distinctive vision. In building the world around the player, we chose to take photographs of roads around Davis that represented the environment and current season without bringing in images of common areas of campus that could potentially distract from the story or provide inconsistencies in our story details (e.g. it wouldn't make sense to be speeding past West Quad throughout the game to get to a Mochi Festival in another city). Using images of roads off-campus would ideally make it easier for our audience to both related to the story but also provide space for their imagination to allow the story to flow well. We ran these backdrops through the [Befunky cartoonizing filter](https://www.befunky.com/create/photo-to-cartoon/) to maintain consistency in visuals.

Animation:

We were able to animate the bike by adding it as a character prefab and used the move function to make it appear as a first-person bike riding down a road. This first-person bike placement helps the player feel as if they are in the game. The movement of the bike helps differentiate the pace and the player's urgency in different scenes, as it moves more frantically in scenes with greater speed and more dangerous paths. Character animations were implemented through the change of expressions. Following the tutorial, we implemented all character prefabs as multi-layer objects to allow placing various expressions on various bodies. We also used the move function on the characters to emphasize times of greater emotion or movement in story.

**Describe how your work intersects with game feel, graphic design, and world-building. Include your visual style guide if one exists.**
After scripting, animation and visuals were the most 

## Input

For our main menu, we used the Left Mouse button to navigate through our "New Game", "Load Game", and "Exit" buttons. We thought this was the easiest possible configuration and also the most logical, especially for our game that would be on the PC.

In the actual game, we used the Right Arrow button, the Left Mouse button, Enter, and Space to scroll through different sections of the text. We also added the ability for the player to quicken the speed at which the text appears on the screen. We realized that some players want to speed through dialogue in order to try different choices than they made previously. As a result, when the text is appearing on the screen, if the player presses either of the two buttons, the text will appear quicker in the text box. We also added the ability to save the game using the "s" key, so that if the player exits the game and then presses "Load Game" on the title screen, the game will load at the exact same point in the story where the player pressed "s".

During the points in the game where the player needs to make a choice, several clickable text boxes will appear on the screen. To select one of them, the player must use the Left Mouse button. Instead of this, we could have had the player press the numerical keys to select the corresponding choice (e.g. pressing the 2 key to select the 2nd choice that appears on the screen). We could have also used the "a" or "b" keys to select the two choices. We decided against this in the end because our current implementation localizes most of the player’s controls to the bottom half of the keyboard, making the experience a little easier and more convenient for them.

## Game Logic

**Document what game states and game data you managed and what design patterns you used to complete your task.**

The most important elements for game logic in a visual novel are the story (narration) and design. The story took a long time for us to get right. The script was rewritten in the last 15 days due to the pace of our original story. We spent a lot of time finding the appropriate sound effects and changed positions and expressions of the characters to keep the player engaged and make the game more lively. For instance, when Ushi is biking, the position of the bike is shifted left/right as the story progresses. 

The design is very minimalistic. There are mainly 3 layers - a background image, characters in the scene, and the narration panel. For the background image, we animated the images we took of the campus, roads, and bike paths. The characters (Kuma, Puma, Muma, and Ruma) are all bears as they are really cute. The narration panel (and choices) is the top layer and the dialogue has a little animation (appearing letter-by-letter). The dialogues are not very long to prevent the cluttering of the narration box. 

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

The testing was done by all the team members in all phases of development. Our initial story was quite long and the gameplay took 20-30 minutes. However, when we playtested the game, we realized that many people who played the game did not enjoy the pacing of the story, and wanted to make more choices in a more action-packed setting. Due to that result, we had to completely change the script with a much fast-paced story. 

With the newer script and changes in the audio, we received a much more positive results. People enjoyed the background music and the sound effects we added. Overall, the feedback from our gameplay testers was that the game has an engaging story and is fun to play. The testers were primarily our friends who played we were scripting the game, and our peers who played during the demo (Tuesday, Dec 10).


## Narrative Design

The story took quite a long time for us to get right. Our original story involved the protagonist Ushi meeting Professor Kuma and enrolling in his ECS 189L class in the spring quarter. Here, Ushi heard about a Mochi Festival that he wanted to get an invite to, but had to impress Professor Kuma with taking certain actions and making certain choices throughout the quarter that would be selected by the player. As a result, we originally planned on having multiple endings depending on the choices that were being made by the player throughout the story. This original story was about 6000-7000 lines long and was heavily story-driven, focused on character development, atmosphere, and dialogue. As a result, playing through the entire game originally may have taken 20-30 minutes.

However, our tests were not positive and because of that, and the fact that our game only had to be playable for around 5 minutes, we decided to completely rewrite the script, and cut out the vast majority of the prologue scene in the arcade. We replaced it with an action-packed story with more dynamic music and quicker pacing to the story. In the context of this project, we thought that this would be a good direction for us. Perhaps if we had more time, we could have built out the original story more. The pacing of a visual novel does not need to be either fast or slow, but in the current context of this project and the relative time constraints, we thought it best to make the game's pacing much quicker.

We have several points in the story where the player has the opportunity to make a certain choice. Some of the choices lead to a continuation in the story, and some of them inevitably lead to a game over. This approach was done for simplicity given the time constraints, and if we had more time, then perhaps we could have created a more dynamic story where different choices lead to different endings, instead of one correct path and several wrong paths.

We wanted to add elements of UC Davis to our story so that the player could better connect with the story and the characters. The story was written by students, for students. Professor Kuma’s personality was not based on any particular professor in real life, we completely created his personality from scratch. But certain aspects of his aesthetic in terms of the asset we used were definitely taken from Professor Josh McCoy. This allowed our audience, which are primarily members of ECS 189L, to relate to the story even more. The other assets we used definitely added to the overall effectiveness of our narrative. We took certain photos or found photos on the internet that we then applied some effects on and incorporated into our game. We used pictures of certain locations in Davis to add to the overall feeling that the player was at UC Davis.


## Press Kit and Trailer

[Mochi Ga Daisuki Press Kit & Trailer](https://dreamy-montalcini-cd3236.netlify.com/)

[Trailer](https://youtu.be/xaPfh_okiPY)

We built a website to introduce our game to the media. The press kit includes a decription of the game, features, release date, trailer, quotes of responses from the demo, samples of character and backdrop images, and an intro to the characters in the game.

We watched a lot of visual novel trailers and tried to implement something similar in our trailer, showcasing parts of the animation and choices in the game as well as the narrative. The trailers runs the audience through the main points of the story and allows them to experience parts of the first-person elements of the game (like the bike). For the audio, we chose the original audio file we had used for the game since it was soft and fun. 

## Game Feel

**Document what you added to and how you tweaked your game to improve its game feel.**

To improve the game feel, we collectively suggested and implemented minor changes as we progressed, to improve the various elements and flourishes that generally engage players in the medium of visual novels.

These include the on screen animations and scene transitions between the characters and backgrounds, the player being able to read the dialogue text, choices as well as the character expressions. For these elements, we tweaked the text's font and size so as to have them be legible and have a contrast with the dialogue box to facilitate the player's actions. The dialogue box's text sequences were implemented such that it was created from the player's mind or that of other characters, usually a few lines at a time to avoid clogging the player's screen with information overload from the get go, with the player's controls triggering the next sequence of lines once they've digested the previous lines. We chose the dialogue box to best fit the relatively light,upbeat and comedic themes of the narrative. 

The choice sections were presented in two main halves, we first had the question slide up the screen on a large panel before positioning it at the top,the choices elaborated in the dialogue box and the buttons below the title in the form of elliptical buttons, which transitions with a fade from a blue to a green hue at an interval that would not be abrupt for the player. These would help inform the player about the context of the decision they are about to make, contemplate on the consequences of each decisions, ensure that they have the agency required to act on what they have decided and generally help their actions of selecting choices feel good holistically.

We spent a lot of time tweaking the music and sound effects to feel just right, by having the our experiences of listening to game music in games generally help steer our choices. We chose sound tracks to best fit the mood and atmosphere of the scenes, helping maximize the feelings of tension and anticipation aroused in the player by including some tracks with intensity that crescendo at fitting moments.  

We believe all of these improvements helped fuel the overall impact that our game left on the player, and really sell the immersive feeling that the tight narratives of visual novels have to offer.
