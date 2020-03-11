Tanvi Bhargava, Intro to Unity, Dec. 2019

NAME OF THIS GAME: Not Asteroids (because it's not Asteroids, but 
it is in space and there are rocks)

You are an astronaut, stranded on a rectangular space orb, separated 
from your spaceship (which is on another space orb). You must navigate 
the otherworldly walls of your space orb, which move of their own 
accord and are fully capable of crushing you (by which I mean will 
break gravity, physics, and any chance you have of reaching your 
spaceship to escape). However, to build a bridge between you and your 
spaceship, you must collect materials, which appear in the form of 
bobbing cubes on the orb's surface. When you have enough, you can use
what you have collected to build the bridge and reach your spaceship!
But one more thing - you only have 150 seconds before you run out of
oxygen. Better act fast.

Credits to PULSAR BYTES for the stylized astronaut character I used,
which came with some camera scripting and animations (press 'w' for
some fun!) And credits to IGGY-DESIGN for the Luminaris Starship I
include at the end (has nothing to do with the game whatsoever).
Also, credits to the Unity forums for help with the algorithm to 
make the walls oscillate. (And debugging.)

The core mechanics of this game: The moving walls and collecting of
cubes to build a bridge. Used collision layers to make sure things
only collided with relevant things. Didn't try to make things too 
complicated.

Game Controls:
'r' to restart
'q' to quit
'y' to change to and from field camera view
'f' to change to and from front camera view
arrow keys or wasd to control moving and turning of astronaut
'w' to make the astronaut run
'p' to place blocks (each bridge piece uses 4 blocks collected!)
^^ Just realized I forgot to make this evident in the game so you'll
need to remember that last one

Note: Collisions are kinda wonky, so you might find yourself having
to catch the blocks with the player's head instead of just running 
into them.
There are regular blocks, which give you 1 block per block collected.
Then there are small red ones which I'm calling iron, which give
you three blocks for each one you collect.
Then there are black ones, which are steel and give you five blocks
for each one you collect, so that's kinda nice.
You also have to get the last block on the spaceship island to win.

Knock knock!
Who's there?
Impatient cow
Impatient cow wh--
MOOO
