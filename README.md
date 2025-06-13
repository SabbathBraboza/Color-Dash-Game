# Color-Dash-Game
 Color Dash Game Made in Unity 6.1

 # Game Controls
   Player controls are 3 buttons with Red, Green and Blue color.
 
  # Game logic explanation
   1. Player Color Change: The Player can Swtich Between Red, Green and Blue Using 3 UI Buttons. and The Current Color is Stored and Updated via The Game Manager script.
   2. Gate Spawning: Gates of Random colors(Red, green and blue) are spawned periodically using the Gate_Spawn script.
   3. Collsion logic:
      When the player collides wiht gates.
      1. if the player's color matchs the gate color Gains 1 Point.
      2. if the player's color does not match: trigger Game Over.
      
   4. Score Management: Score is Increamented through In_Game_UI script when a correct gate passed and Compared against the high score store using PlayerPrefs.
   
# Design Patterns Used
 1. Singleton: Used in Manager like InGameUI, GameManager, AudioManager and PoolManager scripts. to Maintain global, easily accessible instance.
 2. Object Pooling: Used in PoolManager to Spawn and reuse gates efficiently without frequent instantiation/destory.
 3. Event-Driven Programming: UI Buttons Tigger player color changes via Listeners InputManager Scripts.

# Bonus Features Used:
 1. Added Sound Effects for Tapping, Passing Gate, Game Over.
 2. Simple animation On Color Switch.
 
