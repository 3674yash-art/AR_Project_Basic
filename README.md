# 🌸 Markerless Augmented Reality Flower Vase

## 📌 Project Overview
This project is a **Markerless Augmented Reality (AR) application developed using Unity**. It allows users to place a virtual 3D flower vase in their real-world environment without using image markers or QR codes.

Users can interact with the placed vase by changing its **size, colour, and rotation**, providing an interactive and realistic AR experience.

## 🎯 Objectives
- Develop a markerless AR application using Unity.
- Detect real-world surfaces and place a virtual 3D flower vase.
- Allow users to resize, rotate, and change the colour of the vase.
- Explore the use of AR technology for virtual object placement in real environments.

## ✨ Features
- **Markerless Surface Detection:** Detects real-world surfaces using the device camera.
- **3D Object Placement:** Place a virtual flower vase on detected surfaces.
- **Resize Object:** Increase or decrease the size of the vase.
- **Change Colour:** Customize the vase's appearance.
- **Rotate Object:** Rotate the vase to view it from different angles.
- **Real-World Interaction:** View and interact with the virtual vase through the camera.

## 🛠️ Technologies Used
- **Unity** – Game engine and application development.
- **C#** – Scripting and interaction logic.
- **AR Foundation** – Cross-platform AR development framework.
- **ARCore** – AR support for compatible Android devices.
- **3D Models and Materials** – For the flower vase and its appearance.

## ⚙️ Requirements
- Unity Hub and a compatible Unity Editor version.
- AR Foundation package.
- ARCore XR Plugin for Android devices.
- Android smartphone that supports ARCore.
- Android Build Support module installed in Unity.
- A well-lit environment with visible surfaces for reliable detection.

## 🚀 Installation and Setup

1. Clone or download this repository:

   ```bash
   git clone <YOUR_REPOSITORY_URL>
   ```

2. Open Unity Hub.
3. Click **Add Project from Disk** and select the downloaded project folder.
4. Open the project using its compatible Unity Editor version.
5. Ensure that AR Foundation and the ARCore XR Plugin are installed through the Package Manager.
6. Open **Edit → Project Settings → XR Plug-in Management**.
7. Enable ARCore for Android.
8. Connect a compatible Android device and enable USB debugging.
9. Open **File → Build Profiles** (or Build Settings in older Unity versions).
10. Select Android, configure the required settings, and build and run the application.

## 🎮 How to Use

1. Launch the application on your compatible smartphone.
2. Move the camera slowly across the surrounding environment.
3. Point the camera toward a suitable real-world surface.
4. Tap the detected surface to place the virtual flower vase.
5. Use the available controls to:
   - Increase or decrease the vase's size.
   - Change the vase's colour.
   - Rotate the vase.
6. View the vase from different angles by moving around it.

*Note: The available interaction methods depend on the controls implemented in the project.*

## 🧩 Core Components
- **AR Session:** Manages the AR experience.
- **AR Session Origin / XR Origin:** Connects the virtual scene to the device's real-world tracking system.
- **AR Plane Manager:** Detects horizontal or vertical surfaces.
- **AR Raycast Manager:** Identifies detected surfaces when the user taps the screen.
- **Flower Vase Prefab:** The virtual 3D object placed in the environment.
- **C# Scripts:** Handle object placement, scaling, rotation, and colour changes.

*Component names may vary depending on the Unity and AR Foundation versions used.*

## 📂 Project Structure

```text
Markerless-AR-Flower-Vase/
├── Assets/
│   ├── Scenes/
│   ├── Scripts/
│   ├── Prefabs/
│   ├── Materials/
│   └── Models/
├── Packages/
├── ProjectSettings/
└── README.md
```

*The structure above is a suggested layout; adjust it to match your actual repository.*

## 🔮 Future Improvements
- Add realistic shadows and lighting estimation.
- Support multiple virtual objects.
- Add object repositioning and deletion.
- Improve UI design and user experience.
- Support additional AR platforms where compatible.

## 📚 Learning Outcomes
- Understanding markerless AR and surface detection.
- Working with Unity AR Foundation and ARCore.
- Implementing 3D object placement in real environments.
- Using C# to control virtual object properties.
- Exploring interactive AR application development.

## 👨‍💻 Author
**Yash Burad**

## 📄 License
This project is intended for educational and learning purposes. Add a suitable open-source license if you want others to reuse or modify your code.
