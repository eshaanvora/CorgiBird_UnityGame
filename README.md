# CorgiBird

This repo contains program files used to create the CorgiBird game, a spinoff from the popular mobile game "FlappyBird"

The game was created using the Unity Game Engine

Please view the 'DemoScreenShot1.png' and 'DemoScreenShot2.png' files for a sample of the program

In this game, the corgi jumps through towers of beer, and is awarded a point for every tower that it passes through but the game is over when the corgi collides into the tower or is swallowed by the portal that follows the corgi

To make the Corgi's movement more realistic and improve the gameplay of the jump, the movement was modeled based on gravity in which the velocity of the corgi is modified in each frame to resemble a parabolic movement as opposed to a linear movement. If the corgi is moving up, its velocity slows until the zenith, at which point the velocity becomes negative and speeds up the farther it falls.  

The background scrolls endlessly and beer towers are always spawned in a sum of 7 beers (For example: 1 beer in the bottom tower and 6 beers in the upper tower, or 2 beers in the bottom tower and 5 beers in the top tower etc...)

The player can reload the game after losing by typing the "R" key

## Identifying Information

* Name: Eshaan Vora
* Email: EshaanVora@gmail.com

## Script List

* BeerTower.cs
* BeerTowerPicker.cs
* BeerTowerPlacer.cs
* Corgi.cs
* CorgiResetter.cs
* DeathEffectObject.cs
* ForwardMovingObject.cs
* Game.cs
* KeyboardInput.cs
* LoopingBackground.cs
* PortalSpawner.cs
* Readouts.cs
* RToReload.cs
* ScoreCounter.cs
* Sounds.cs
* SpriteTools.cs

## Known Errors

* None
