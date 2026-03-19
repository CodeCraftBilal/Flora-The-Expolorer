
# Flora The Explorer

Flora The Explorer is an interactive and engaging exploration-based game where players navigate through a vibrant environment, interact with objects, and complete challenges. The game focuses on discovery, user interaction, and dynamic gameplay elements.
[Download Flora The Explorer PC ⬇️](https://github.com/CodeCraftBilal/Flora-The-Expolorer/releases/download/v1.0.0/FloraTheExplorer-v1.0.exe)
[Download Flora The Explorer Mobile ⬇️](https://github.com/CodeCraftBilal/Flora-The-Expolorer/releases/download/v1.0.0/FloraTheExplorer-v1.0-mobile.apk)
## 🎮 Features

🌱 Interactive Gameplay
Click-based interactions with objects (e.g., fruits, items, or targets).

🎯 Score System
Real-time score tracking based on player actions.

⏱️ Timed Challenges
Targets appear for a limited time to increase difficulty and engagement.

🍎 Dynamic Object Spawning
Objects (like fruits) fall or appear at intervals to create continuous gameplay.

🔊 Sound Effects
Audio feedback for interactions to enhance user experience.

🧠 Target-Based Objectives
Players must find and interact with specific objects shown as targets.

💀 Game Over System
Game ends based on certain conditions (e.g., missed targets or score threshold).

🎨 Simple UI System
Displays:

Current Score

Final Score

Target Object

Game Over Panel

## ⚙️ How It Works
1. Game Start

The game initializes the score and UI elements.

A target object is displayed to the player for a short duration.

2. Object Spawning

Objects (e.g., fruits) are spawned at regular intervals using a spawning script.

These objects fall or move within the scene.

3. Player Interaction

The player interacts by clicking on objects.

When an object is clicked:

If it matches the target → ✅ Score increases

If it doesn't match → ❌ Possible penalty or ignored

4. Score Management

The score is updated in real-time.

UI reflects the current progress instantly.

5. Target Display System

A target object is shown temporarily.

Player must remember and find that object among others.

6. Game Over Logic

Game ends when:

A condition is met (e.g., wrong clicks, time limit, or missed targets).

Final score is displayed on the Game Over panel.

🛠️ Technologies Used

Unity Engine

C# Scripts

Unity Components:

MonoBehaviour

GameObject

Collider2D

UI (Text, Panels)

AudioSource

📂 Project Structure (Example)
```
Flora-The-Explorer/
│── Assets/
│   ├── Scripts/
│   │   ├── ScoreScript.cs
│   │   ├── DestroyOnClickScript.cs
│   │   ├── FruitDropperScript.cs
│   ├── Prefabs/
│   ├── Scenes/
│   ├── UI/
│
│── ProjectSettings/
│── README.md
```
🚀 Getting Started
Clone the repository:

git clone https://github.com/your-username/flora-the-explorer.git

Open the project in Unity Hub

Load the main scene

Press ▶️ Play to run the game