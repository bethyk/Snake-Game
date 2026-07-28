# Snake Game

Snake Game is a classic arcade-style game developed with **Unity** and **C#**. The project includes a start menu where the player can begin the game or exit, followed by the traditional snake gameplay experience.

The player controls a continuously moving snake, collects food to grow longer, and tries to achieve the highest possible score without colliding with obstacles or the snake's own body.

## Features

- Classic snake gameplay
- Start menu with play and exit options
- Keyboard-controlled movement
- Food collection and snake growth
- Score-based gameplay
- Collision and game-over mechanics
- Unity scene-based structure
- Custom visual interface and game assets

## Technologies

- Unity
- C#
- Unity 2D
- Unity UI
- Visual Studio

## Controls

| Action | Key |
|---|---|
| Move up | Up Arrow / W |
| Move down | Down Arrow / S |
| Move left | Left Arrow / A |
| Move right | Right Arrow / D |

Controls may depend on the input configuration used in the Unity project.

## Project Structure

```text
Snake-Game/
├── Assets/              # Game scenes, scripts, sprites, audio, and UI assets
├── Packages/            # Unity package configuration
├── ProjectSettings/     # Unity project settings
└── README.md            # Project documentation
```

Important folders inside `Assets/` may include:

```text
Assets/
├── Scenes/              # Menu and gameplay scenes
├── Scripts/             # C# game logic
├── Sprites/             # Snake, food, background, and interface graphics
└── UI/                  # Menu buttons and other interface elements
```

The exact folder names may vary depending on the Unity project organization.

## Installation and Usage

### 1. Clone the repository

```bash
git clone https://github.com/betulkizilkaya/Snake-Game.git
cd Snake-Game
```

### 2. Install Unity Hub

Download and install Unity Hub, then install a Unity Editor version compatible with the project.

### 3. Open the project

1. Open Unity Hub.
2. Select **Add project from disk**.
3. Choose the cloned `Snake-Game` folder.
4. Open the project with the recommended Unity version.

### 4. Run the game

Open the starting menu scene from the `Assets` folder and press the **Play** button in the Unity Editor.

## How to Play

1. Launch the game.
2. Select the start option from the main menu.
3. Control the snake with the directional keys.
4. Collect food to increase the snake's length and score.
5. Avoid collisions that end the game.
6. Try to achieve the highest possible score.

## Building the Game

To create a standalone build:

1. Open the project in Unity.
2. Go to **File > Build Settings** or **File > Build Profiles**, depending on the Unity version.
3. Add the menu and gameplay scenes to the build.
4. Select the target platform.
5. Click **Build**.

Make sure the menu scene is placed first in the scene list so the application starts from the main menu.

## AI-Generated Assets

The visual assets used in this project were created with the assistance of artificial intelligence tools. These assets were selected, organized, and integrated into the Unity project by the project developer.

## Notes and Possible Improvements

Possible future improvements include:

- Difficulty levels
- Increasing movement speed
- Persistent high-score storage
- Pause and restart controls
- Sound effects and background music
- Mobile touch controls
- Additional maps and visual themes
- Improved game-over and score screens

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

© 2024 [Betül Kızılkaya](https://github.com/betulkizilkaya)
