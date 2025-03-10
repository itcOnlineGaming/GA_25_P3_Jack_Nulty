# Guide
# Modular Grid Builder

## **Overview**
This component is a **modular grid-based object builder**, allowing users to dynamically construct game objects within Unity. It features a **hotbar system**, where each slot can hold a predefined **game object prefab** assigned in the Unity editor.

## **How It Works**
### **1. Prefab Selection & Spawning**
- The user selects a prefab from the hotbar by clicking on the corresponding button.
- This action spawns an instance of the selected prefab into the grid.

### **2. Grid-Based Drag & Drop System**
- Once spawned, the object can be **dragged** into any available slot within the grid.
- The grid serves as a **construction area**, where multiple objects can be placed to form a more complex structure.
- Objects can be repositioned or replaced dynamically, allowing for modular and flexible design.

### **3. Building a Custom Game Object**
- By arranging and combining objects within the grid, players can **build a fully customized** game object.
- This final structure can then be used within a scene, potentially for gameplay purposes such as:
  - **Placing a structure**
  - **Assembling a character**
  - **Creating an interactive object**

## **Customization & Use Cases**
- The system supports **various prefab types**, such as:
  - Blocks
  - Furniture
  - Character parts
  - Mechanical components
- Ideal for:
  - **Sandbox games**
  - **Level editors**
  - **Crafting systems**
  - **Modular design tools** within Unity
- Developers can **easily modify the available objects** in the Unity editor by assigning different prefabs to the hotbar slots, allowing for limitless customization.


## Setting up Component

You need to add the component to your project using the Package Manager. Open the Package Manager (Windows > Package Manager), click on the + icon and select “Add package from git URL...” and enter:

https://github.com/itcOnlineGaming/GA_25_P3_Jack_Nulty.git?path=/GameObjectGridBuilder/Packages/ie.setu.gameobjectgridbuilder#v0.0.1

Note that the URL specifies the complete path to the package and a git tag. The package should now be visible in your project.

## Using the component
### Basic Grid
To create a basic grid you need to instantiate a grid and hotbar system.
You then need to apply prefabs from your game or application to each hotbar slot which will create instantations on the click of these buttons to be dragged into grid slots.
This can be done using touch-screen and mouse clicks.
![image](https://github.com/user-attachments/assets/deb55da8-37c7-429a-81bd-24d644675e6e)

