# WinterWonderJam

## Devlog

### 2 December 2023 | 15:30
- Finished setting up the animation clips for the snowman and fire. Fixed issue with animations no playing on the game objects.
- Added hearts to UI HUD and created a display for the sticks.
- Added functionality to UI (displays fire timer, fire health with hearts, and sticks).
- Set up animator for flipping the snowman's animation based on which direction its going.
- Implement snowman death anim and death
  
  
### 2 December 2023 | 18:30
- Implemented killing snowmen
- Implemented snowmen dropping sticks
- Created prefabs on gameObjects that will be instantiated

#### Thing to be Done
- finish setting up player animation clips (need: idle anim, left walk anim, right walk anim, left walk anim with stick, right walk anim with stick)
- fix player animator controller (doesn't quite work right yet)
- enemy manager for spawning in enemies
- item manager for spawning in coal
- start screen (buttons and instructions) [DONE]
- end of game scene (game over screen and button to restart) [DONE]
  
- implement power ups [Will be saved for later]


### 3 December 2023 | 11:00
- Added Start, How to Play, and Game Over screens with functioning buttons
- Implemented scene change and end game behavior (when the fire loses all health or timer ends, the game over screen is shown)