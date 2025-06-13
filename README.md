# Color-Dash-Game
 Color Dash Game Made in Unity 6.1

 # Game Controls
   player controls are 3 buttons with Red, Green and Blue color.
 
  # Game logic explanation
   Core Mechancs:
   1. The Player Stay stationery.
   2. Gates appears At intervals and move towards player each gate having a specific color: Red,Green or Blue.
   3. The Player must tap the corresponding color button to change their character's color to match the gate.
   4. if the character passes through a gate with a matching color, the game continues and the player earns 1 point.
   5. if the character passes through a gate with a non matching color, the  game over.

# logic Used
 1. Game Manager Handles logic between player and gates
 2. Gates have tags: Red, Green and Blue.
 3. Used Object pooling for spawning the Gates.
 4. Patterns Used: Singleton, Object Pooling, Observer/Events and State Pattern.

# Bonus Features Used:
 1. Added Sound Effects for Tapping, Passing Gate, Game Over.
 2. Simple animation On Color Switch.


   
       
  
