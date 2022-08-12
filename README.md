# Pursuing-My-Dream

Here i will share my learnings with this simple project. The idea is to get used with Unity and keep gradually working into the project.
<br>
As i say, "slow and steady".

Project idea:
To create a simple level were i can experiment with the tools Unity provides. Like a "tech demo" of what i can do with the tools available.

Already implemented:
- Character movement, with built-in debug features
- Character animations, simple but functional
- Effectors 2d, serving as examples of what they can do (with some UI explanations of them)
- Audio manager script, that handles, dynamically, all of the game sounds
- All sprites for the yellow slime / ground / trees and bushes are mine (not using the trees and bushes right now). I've spent some time with Aseprite and ended up mading then 😆
- Background scenery with parallax effects and infinite horizontal / vertical scrolling
- Shooting mechanics with built-in object pooling: 5 different shoot (3 main, 2 alternate versions). Alternate version make use of a new energy consumption mechanic
- Floating magical gem and its bullets has a visual aspects function - nicer effects and stuff!
- Implemented a target dummy spawner with animated targets and damage mechanic
- Implemented a fully functional upgrade system: shoot strength, speed, range, rate of fire upgrades! Max energy and energy regen too!
- Implemented the player health system which is too upgradeable
- Implemented a pause feature with a pause menu showing all current upgrade ranks the player has, for each statistics (with UI explanation)
- Implemented a damage indicator feature so the player can see the ammount of damage being inflicted on enemies
- Progress is now maintained between scenes with the use of scriptable object
- Shop now available! Player can spend those coins on some stuff

Next steps:
- Finish the visual aspects of the level
- Do some physics related tweaks
- Create a second level with an objective (reach point B)

Lil demo: https://itsamewill.github.io/PursuingMyDream-Demo/
<br>
Controls:
<br>
WASD movement
<br>
Spacebar to jump
<br>
Mouse controls the crosshair (press ESC to show / hide the mouse cursor)
<br>
Left click: normal shoot - Right click: alternate version, consumes energy
<br>
Keypad 1: default shoot, no alternate version
<br>
Keypad 2: spread shoot, faster rate of fire but less accurate. Alternate version: burst stream, extremely fast and precise.
<br>
Keypad 3: guided shoot, tracks the closest target from the player. Alternate version: projectile cluster, spawns several mini versions of itself.
<br>
Press M to mute / unmute the music
<br>
Press E to activate visual effects
<br>
Press R to activate object pooling (to test performance in mobile devices)
<br>
Press Escape to pause / unpause the game
