\# 2.5D Aim Trainer



> A fast-paced 2.5D reaction and target-acquisition training tool developed in Unity and C#, designed to measure and improve mechanical mouse accuracy, target tracking, and flick speed.



\[!\[Unity Version](https://img.shields.io/badge/Unity-2022.3%20LTS-blue.svg)](https://unity.com/)

\[!\[Language: C#](https://img.shields.io/badge/Language-C%23-239120.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)

\[!\[Platform](https://img.shields.io/badge/Platform-Windows-lightgrey.svg)]()

\[!\[License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)



\---



\## Overview



\*\*2.5D Aim Trainer\*\* is an arcade-style precision training game built as an A-Level Computer Science project. Combining a 2D perspective with spatial 3D depth, the application provides an isolated, responsive environment for players to hone first-person shooter (FPS) mouse mechanics without extraneous engine overhead.



The project incorporates structured state management across dedicated game states (menus, dynamic gameplay sessions, pause screens, and real-time game-over performance summaries).



\---



\## Key Features



\- \*\*2.5D Target Generation:\*\* Spawns interactive target prefabs dynamically across a constrained spatial field to test horizontal, vertical, and depth target acquisition.

\- \*\*Dedicated Game Modes:\*\* Modular target routines tailored toward micro-adjustments, flick shots, and sustained tracking.

\- \*\*Comprehensive State Architecture:\*\* Clean separation of concerns across menu navigation, active gameplay loops, pause handling, and game-over analytics.

\- \*\*Custom UI \& Typography:\*\* Integrated TextMesh Pro styling and responsive UI canvases for real-time score display and post-run performance breakdowns.

\- \*\*Configurable Control Interface:\*\* Built-in controls overview ensuring seamless mouse calibration and input handling.



\---



\## Controls



The game relies entirely on raw mouse input for low-latency target acquisition:



| Input | Action | Function |

| :--- | :--- | :--- |

| \*\*Mouse Cursor\*\* | Aim / Navigate | Direct spatial crosshair movement across the target plane |

| \*\*Left Mouse Button (LMB)\*\* | Click / Fire | Destroy active targets and interact with UI menus |

| \*\*Escape (`Esc`)\*\* | Pause | Open the pause menu to pause active timers and target loops |



\---



\## Tech Stack \& Requirements



\- \*\*Engine:\*\* Unity 2022.3 LTS

\- \*\*Language:\*\* C# (.NET Standard 2.1)

\- \*\*UI Framework:\*\* TextMesh Pro (TMP) + Unity UI (UGUI)

\- \*\*Target Platform:\*\* Windows 10 / 11



\---



\## Getting Started



\### Prerequisites

\- \[Unity Hub](https://unity.com/download)

\- Unity Editor version \*\*2022.3 LTS\*\* (or compatible patch release)



\### Installation \& Local Setup



1\. \*\*Clone the repository:\*\*

&#x20;  ```bash

&#x20;  git clone \[https://github.com/Natewa101/Aim-Trainer-project.git](https://github.com/Natewa101/Aim-Trainer-project.git)

&#x20;  ```

2\. Open \*\*Unity Hub\*\*.

3\. Click \*\*Add > Add project from disk\*\* and select the root directory of the cloned project.

4\. Allow Unity Hub to compile package dependencies and launch the Editor.

5\. In the \*\*Project\*\* window, navigate to `Assets/Scenes/`.

6\. Double-click `Main\_Menu.unity` to load it, then click the \*\*Play\*\* button at the top of the editor.



\---



\## Architecture \& Codebase Structure



The project separates logic by game state and system responsibility:



```text

Assets/

├── PreFabs/              # Reusable target entities and particle effects

├── Resources/            # Dynamic assets, fonts, and materials loaded at runtime

├── Scenes/               # Distinct scenes for MainMenu, GameModes, and Arena

├── Scripts/              # Modular C# source code

│   ├── ControlMenu/      # Sensitivity and control bindings management

│   ├── GameMode/         # Game mode rule definitions and session logic

│   ├── GameOverScreen/   # Session evaluation, statistics, and score persistence

│   ├── MainMenu/         # Main menu flow, transitions, and mode selection

│   ├── Pause\_Menu/       # Time-scale manipulation and mid-run escape handling

│   └── PlayingGame/      # Target spawning loops, raycasting, and hit detection

└── TextMesh Pro/         # TMP asset definitions, custom shaders, and font sheets

```



\---



\## License



This project is open-source and available under the \[MIT License](LICENSE).

