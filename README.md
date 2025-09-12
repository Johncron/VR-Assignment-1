CSC 461 – Assignment 1 Unity Basics


Scene 1 
This scene contains a plane and 3 primative objects all with different material colors.
<img width="1400" height="805" alt="image" src="https://github.com/user-attachments/assets/d313310f-1a6f-4141-9bbb-367aeb6fe47d" />

--Bonus--
I added a script that changes the color of the material on each object to a random color in the Start method.
<img width="2295" height="1126" alt="image" src="https://github.com/user-attachments/assets/903dbb63-e794-46aa-8693-7fd7f3d59dfb" />

Scene 2
This scene contains a maze made up of resized cubes, a capsule object as the player and a camera that follows the player.  The player has a player controller script that reads wasd and arrow key inputs to move the object.

<img width="2258" height="1095" alt="image" src="https://github.com/user-attachments/assets/fa48731d-4152-43ac-94f5-9b7c90e6d456" />

<img width="1393" height="951" alt="image" src="https://github.com/user-attachments/assets/c90edda7-d9f4-4b9a-9c85-57346d1fa71f" />

Scene 3
This scene contains a Meta XR camera rig and the skybox is using the skybox/panoramic shader and uses a panoramic image.

<img width="2306" height="1101" alt="image" src="https://github.com/user-attachments/assets/de94a8fb-c72d-4ad9-9767-40d2d5d9e7ea" />

--Difficulties--
I encountered a persistent error involving the Android SDK and related dependencies.  I am not sure why it caused such an error, maybe the Meta headset is an Android device.  I fixed the error by going into the build settings and downloading everything for Android, even though the project is intended for Windows, Mac, Linux.
