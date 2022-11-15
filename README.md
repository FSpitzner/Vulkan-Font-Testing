# Vulkan-Font-Testing

This Project was created for a Unity Bugreport. This Project is meant to be run on an Oculus Quest 2.
To reproduce the Bug follow these steps:

1. Open this Project with Unity 2021.3.11LTS (Android Build Support is required)
2. Open the Scene SampleScene.unity located in the "Scenes"-Folder
3. Build as is for Android to establish a working baseline
4. Deploy the Build on an Oculus Quest 2 and run it. Observe that everything works as intended.
5. In the Hierachy search for "TextMeshProUGUI", select all 3 and change the Font Asset to "Oswald Regular SDF"
6. Save the Scene and Build the Project again
7. Deploy again on an Oculus Quest 2 and run the build. Observe that the game will freeze within seconds.
