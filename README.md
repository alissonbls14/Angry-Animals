# Angry Animals


<img width="1153" height="647" alt="Captura de tela 2025-09-27 183648" src="https://github.com/user-attachments/assets/d83756f9-b384-458d-96c1-749c5143c4b5" />
<img width="1151" height="646" alt="Captura de tela 2025-09-27 183822" src="https://github.com/user-attachments/assets/ac157554-0980-46d0-840b-8d65f74cc603" />
<img width="1150" height="643" alt="Captura de tela 2025-09-27 183751" src="https://github.com/user-attachments/assets/4241126e-187d-43fc-ac7d-ee84d9fd9862" />
<img width="1154" height="648" alt="Captura de tela 2025-09-27 183707" src="https://github.com/user-attachments/assets/335cceeb-fa4a-4fbe-b634-c2ccbae367eb" />


**Angry Animals** is a physics-based game inspired by *Angry Birds*, developed in **Godot 4 with C#**.  
It started as a learning project, but you can now play it yourself!  
---

## 📌 Features
- Drag-and-release mechanics with physics-based projectiles.
- Score tracking per level with save/load support.
- Simple UI for attempts and game over screen.
- Signal-based event handling (animals, cups, levels).
- Clean and well-documented C# code.

---

## 🎮 How to Play
- Drag the animal with the mouse (or finger on mobile).
- Release to launch it against the cups.
- Destroy all cups to complete the level.
- Your **score** is based on the number of attempts (the fewer, the better!).

---

## 📥 Download

---

## 📂 Code Included
This repository contains **all the scripts** used in the game.  
The assets (art, sounds, etc.) are **not included**, since they belong to my professor.
Credits: [Richard Albert, Martyna Olivares](https://www.udemy.com/course/learn-2d-game-development-godot-43-c-from-scratch/?couponCode=KEEPLEARNINGBR#instructor-1)

Scripts overview:
- `Animal.cs` – Drag, release, collisions, and state machine.  
- `Level.cs` – Spawns animals and manages the flow of each level.  
- `Cup.cs` – Breakable cups with animations.  
- `Scorer.cs` – Tracks destroyed cups and attempts.  
- `Ui.cs` – Updates attempts and shows game over.  
- `ScoreManager.cs` – Saves/loads best scores per level.  
- `FileManager.cs` – JSON save system (`animals.save`).  
- `SignalManager.cs` – Centralized events (animal died, cup destroyed, etc.).  
- `GameManager.cs` – Scene loader.  
- `Button.cs` – Level select buttons.  
- `Water.cs` – Detects when animals fall into the water.

---

## 📜 License
This project is for **educational purposes**.  
You can play it freely, and you may also study the code.  
If you reuse the scripts, please give credit.
