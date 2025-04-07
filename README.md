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

## **Customisation & Use Cases**
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

Note that the URL specifies the complete path to the package and a git tag. The package should now be visible in your project. This will be found under the package folder in your project under the name GameObjectGridBuider.

## Using the component
### Basic Grid
To create a basic grid you need to instantiate a grid and hotbar system.
To do this you must get the canvas prefab from the package runtime file and drag it into the current scene to add it.
You then need to apply prefabs from your game or application to each hotbar slot which will create instantations on the click of these buttons to be dragged into grid slots.
This can be done using touch-screen and mouse clicks.
![image](https://github.com/user-attachments/assets/c57b184a-b737-4399-98da-9bd2401428e0)

## Must Haves:
To set up the grid you must make an empty gameobject and give it the scripts from the package, you will add the Load Part script and add all your prefabs to the list, these prefabs must have a rigidbody, boxcollider which is inactive on the prefab build scene and must have the packages joint creator script.
- Rigidbody
- Boxcollider (inactive in builder scene)
- Joint creator script from package

Then set up an empty game object with 1 single base object to be the centre of the object you will build.
This must have:
- Base gameobject with tag "gameObj"
- 1 object prefab as the start of your build with the tag "objBase"
- This objBase must have the Joint Creator script with the gameObj and objBase assigned as the variables
- Must have same properties as the prefabs above

![image](https://github.com/user-attachments/assets/d3690de6-1b1d-4849-b4e2-ac93010890dc)

Then just add the name of the scene the gameobject that you create will move to, add this name in the sceneloader script and then add any required code that must be added to the asyncronse load function.
# Possible Customisations
- Can change values of joints to make object more or less brittle.
- Change values of gravity to make object floaty or higher gravity.
- Give the object movement values if you are making an object such as a car

![image](https://github.com/user-attachments/assets/de7d2369-8cf9-40c3-a4fb-7bc02a8410e6)



