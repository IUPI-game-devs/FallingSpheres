# Project 06 - Falling Spheres

## Description

The game consists of a player shooting enemies while trying to avoid falling through a collapsing floor. Hitting walls causes the floor tiles to disappear. The player wins by destroying all enemies and loses by falling through the floor or running out of health.

The goal is to use manager classes to control the game logic and state.

## Managers

**GameManager** - Singleton class that tracks score, health, and game state. Provides events for game events like enemy destroyed. Controls win/lose condition.

**EnemyManager** - Singleton manager that maintains a list of active enemies. Handles spawning and destroying enemies.

**FloorManager** - Manages grid of floor tiles. Can destroy random tiles based on certain events.

**WallManager** - Manages grid of walls. Can destroy random walls based on certain events.

## Scenes

- **Game** - Main game scene where gameplay occurs.

- **Win** - Shown when player completes all waves.

- **Lose** - Shown when player health reaches 0.

## Objectives

- Learn to implement the singleton pattern for managers
- Use manager classes to control overall game state
- Leverage events/delegates for loose coupling between classes
- Employ inheritance and interfaces for better code reuse

## Documentation

### Base Creation

We created a base using the Sci-Fi styled assets from the Unity Asset Store.

**Floor**

- The floor is made up of a 4x4 grid of tile prefabs. 
- Each tile prefab contains a simple plane mesh renderer with box collider.
- The floor tiles are spawned by the FloorManager at start to populate the playing area.

**Walls** 

- The walls use a modular sci-fi wall panel prefab.
- Each side wall is made up of 8 wall panel prefabs positioned together.
- The wall prefabs have box colliders and triggers to detect bullet hits.

**Layout**

- The overall base is laid out like a square with the floor tiles in the center.
- The corner walls connect and fill in the gaps between side walls.
- The base game object acts as a template that is invisible to the player.

![Base Layout](./images/Base-layout.png)

For the lose and win screen we used a combination of generative AI. We tried to use the Dalle-2 for the images and StableDiffusionXL. 


