# Augmented-Reality-AR-and-Virtual-Reality-VR-
A collection of AR/VR projects built in Unity, featuring interactive AR Language Flashcards and a VR/AR Car Simulator.
# 🌍 AR Language Flashcards

This is an Augmented Reality (AR) application built in **Unity** that brings language learning to life. It uses image tracking to recognize physical flashcards and overlays them with 3D models, text, and audio, creating an engaging and multisensory learning experience.

[Image of AR flashcard in action]

## 🚀 Features

* **Image Tracking:** Recognizes multiple, unique flashcard images.
* **3D Visualization:** Renders a relevant 3D model in AR for each card (e.g., an apple model for the "Apple" card).
* **Audio Pronunciation:** Plays a sound clip of the word being pronounced in the target language.
* **Text Labels:** Displays the correctly spelled word on-screen.
* **Cross-Platform:** Built with **AR Foundation**, it's deployable to both iOS (ARKit) and Android (ARCore).

---

## 🛠️ Tech Stack

* **Engine:** Unity 2021.x or higher
* **AR Framework:** AR Foundation
* **Platforms:** ARCore (Android) & ARKit (iOS)
* **Scripting:** C#

---

## ⚙️ Setup and Installation

To get this project running on your own device, follow these steps:

**1. Clone the Repository**
```bash
git clone [https://github.com/your-username/ar-flashcards.git](https://github.com/your-username/ar-flashcards.git)
cd ar-flashcards
```

**2. Open in Unity**
* Open Unity Hub and "Add" the cloned project folder.
* Ensure you have the correct Unity version installed.

**3. Install Packages**
* Go to `Window > Package Manager`.
* Install the following packages:
    * **AR Foundation**
    * **ARCore XR Plugin** (for Android)
    * **ARKit XR Plugin** (for iOS)

**4. Set Up Image Library**
* In the project assets, find the `ReferenceImageLibrary`.
* Add your own images (PNG or JPG) to be used as flashcards.
* Connect this library to the `AR Tracked Image Manager` component in your scene.

**5. Build for Your Device**
* Go to `File > Build Settings`.
* Switch to either **Android** or **iOS**.
* Ensure your **Player Settings** (especially AR settings like "ARCore Required") are correct.
* Click **Build and Run** with your device connected.

---

## Usage

1.  **Print the Flashcards:** Print the image targets located in the `/FlashcardImages` directory.
2.  **Launch the App:** Open the app on your Android or iOS device.
3.  **Scan:** Point your device's camera at one of the printed flashcards.
4.  **Learn:** Watch the 3D model appear, read the text, and listen to the pronunciation!

---





# 🚗 AR/VR Car Simulation

This Unity project demonstrates a flexible car simulation with two distinct modes: an immersive **Virtual Reality (VR)** driving experience and a tabletop **Augmented Reality (AR)** remote-control mode.

The project shares a single core logic for car physics (using Wheel Colliders) and controls, adapting the user's interaction based on the platform.




## 🚀 Features

* **VR Mode (PC/Quest):**
    * **First-Person Driving:** Sit in the driver's seat of a full-scale car.
    * **VR Controls:** Steer, accelerate, and brake using VR controllers (e.g., Oculus Touch, Index).
    * **Immersive Environment:** Drive around a 3D-modeled test track or city.

* **AR Mode (Mobile):**
    * **Plane Detection:** Scans your real-world environment (floor or table).
    * **Place Object:** Tap to place the car on the detected surface.
    * **RC Controls:** Use on-screen UI (joysticks, buttons) to drive the car in your room.

---

## 🛠️ Tech Stack

* **Engine:** Unity 2021.x or higher
* **VR:** OpenXR Plugin
* **AR:** AR Foundation
* **Platforms:** PC (VR), Oculus Quest (VR), Android (AR), iOS (AR)
* **Physics:** Unity Wheel Colliders
* **Scripting:** C#

---

## ⚙️ Setup and Installation

This project requires switching between build targets (PC for VR, Mobile for AR).

**1. Clone the Repository**
```bash
git clone [https://github.com/your-username/ar-vr-car-sim.git](https://github.com/your-username/ar-vr-car-sim.git)
cd ar-vr-car-sim
```

**2. Open in Unity**
* Open Unity Hub and "Add" the cloned project folder.

**3. Install Packages**
* Go to `Window > Package Manager`.
* Install the following packages:
    * **OpenXR Plugin** (for VR)
    * **AR Foundation** (for AR)
    * **ARCore XR Plugin** (for Android AR)
    * **ARKit XR Plugin** (for iOS AR)
    * **Input System** (for new input handling)

---

## Scenes

This project contains two primary scenes:

* `VRCarScene.unity`: The scene for the PC/Quest VR driving experience.
* `ARCarScene.unity`: The scene for the mobile AR remote-control experience.

## 🚀 How to Run

### For VR (PC/Quest)

1.  Go to `File > Build Settings`.
2.  Set the **Platform** to `PC, Mac & Linux Standalone` or `Android` (if building for Quest).
3.  Open the `VRCarScene.unity` scene.
4.  Ensure your VR headset is connected.
5.  Click **Play** in the editor (for PC VR) or **Build and Run** (for Quest).

### For AR (Mobile)

1.  Go to `File > Build Settings`.
2.  Set the **Platform** to `Android` or `iOS`.
3.  Open the `ARCarScene.unity` scene.
4.  Configure your **Player Settings** for AR.
5.  **Build and Run** on your connected mobile device.
6.  Once the app opens, scan a flat surface until a plane is detected.
7.  Tap the screen to place the car.
8.  Use the on-screen controls to drive.


1.  Fork the repository.
2.  Create a new branch (`git checkout -b feature/NewLanguage`).
3.  Make your changes and commit them (`git commit -m 'Add Spanish language support'`).
4.  Push to the branch (`git push origin feature/NewLanguage`).
5.  Open a Pull Request.
