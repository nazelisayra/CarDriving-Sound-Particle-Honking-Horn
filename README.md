Car Driving Game 🚗💨

Overview
This project is a small, polished Unity 3D racing/driving prototype demonstrating essential game development concepts, including object pooling, randomized environment generation, sound design, and player input handling. The core gameplay involves driving a vehicle down a road while collecting items and avoiding obstacles.

Key Features
The project implements several fundamental game mechanics:

1. Dynamic Environment Generation
Collectible Items: Implemented similar to the "Roll-a-ball" style, players can collect objects scattered across the road.

Random Placement: Both collectible items and obstacles are generated and placed randomly along the road at the start of the game, ensuring a unique layout for each run.

Randomized Movement: Obstacles are programmed to move across the X-axis with randomized start times (phase offset), ensuring non-synchronous and unpredictable movement patterns.

2. Audio and Feedback
Collision Feedback: Distinct sound effects and particle effects trigger on collisions. Object tags are used to correctly identify and differentiate between collisions with Collectibles and Obstacles.

Looping Music: A background track provides an immersive atmosphere.

Horn Input: The player can trigger a horn sound effect using a key press (Spacebar).

