# Tomb of Shadows Curse of the Nile

Tomb of Shadows Curse of the Nile is a horror game project made by [Hopium](https://hopium.itch.io/) during a 1 month IGI competition. 

The game is based on ancient egpyt and your goal is to get to the artifact by opening 5 gates, however you must becareful because there are monsters patrolling the place. 

Game Enginge: Unity Editor Version 2021.3.21f1

Link to the game: https://hopium.itch.io/tomb-of-shadows-curse-of-the-nile 

Link to the game's trailer: https://youtu.be/X2aks1UKQ-4?si=ewKrLfDJq2mwIuSy

![image](https://github.com/Lemun8/Tomb-of-Shadows-Curse-of-the-Nile/assets/107360799/5cb7c379-f474-429d-8ab2-e28e4dab9af4)



# Story

You are an explorer who ventures to the depth of ancient egypt to find the artifact. It is said that the artifact grants immortality to those who are able to touch it. Little do they know, the artifact holds great evil within.

![image (4)](https://github.com/Lemun8/Tomb-of-Shadows-Curse-of-the-Nile/assets/107360799/8d2f4197-7640-4003-a2ae-a4f04461e4f0)


# Gameplay

First Person camera mechanic, you are equipped with a flashlight, the player must be able to avoid the patrolling monsters and get to the artifact.

![image (1)](https://github.com/Lemun8/Tomb-of-Shadows-Curse-of-the-Nile/assets/107360799/89e420e5-1189-4b45-bc22-c2935fb3b897)


# Main Objective

Open the gates, get to the artifact.

![image (3)](https://github.com/Lemun8/Tomb-of-Shadows-Curse-of-the-Nile/assets/107360799/3d68f87b-3ac5-4d83-8784-4462d9dcf7d0)


# Player Control

| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Movement          |
| Left Shift        | Sprint            |
| Left Click        | Interact          |
| F                 | Toggle Flashlight |
| Esc               | Pause             |
| Spacebar          | Jump              |
| Mouse             | Look Around       |

# Codes Explained

### Enemy Pathfinding AI

The enemy AI generates a random number before deciding where to go on the location in the map. Paths were decided with each corresponding number, for example if the number generated is 5 then the enemy will go to the general area of the number 5, after the enemy patrols around the are then it will generate a new number that it will use to travel.

![Screenshot 2023-10-04 223639](https://github.com/Lemun8/Tomb-of-Shadows-Curse-of-the-Nile/assets/107360799/03222bc3-4f48-477c-b4a7-f4ab6af68090)

![Screenshot 2023-10-04 223815](https://github.com/Lemun8/Tomb-of-Shadows-Curse-of-the-Nile/assets/107360799/1141fc7c-cbb0-4344-9458-86fe24a5129a)



### Enemy Chasing AI

The enemy has a box collider that will trigger its chase to the player if the tag "player" is in its box collider. The box collider will act as a vision range for the monster. Once the player passes the enemy's vision then it will start to chase the player with a running animation, the chase lasts for 5 seconds before the enemy stops chasing the player (if you're out of its chase vision).

![Screenshot 2023-10-04 223738](https://github.com/Lemun8/Tomb-of-Shadows-Curse-of-the-Nile/assets/107360799/94801040-a92a-4370-b5c7-3863158094d3)

![Screenshot 2023-10-04 223837](https://github.com/Lemun8/Tomb-of-Shadows-Curse-of-the-Nile/assets/107360799/cde8d5d2-aa35-4601-9daa-b885280f5a33)


# Credits

Johan Ariel - **Game Programmer & Game Designer** <br>
Garyn Norbert Gunawan - **Game Artist** <br>
Sebastian Gabriel - **Sound Designer** <br>

