using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AdventOfCodeScript))] // Target your main script here
public class MyScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI(); // Draws the default inspector

        AdventOfCodeScript script = (AdventOfCodeScript)target;

        if (GUILayout.Button("Run Code"))
        {
            script.RunCode(); // Calls the function when the button is pressed
        }
    }
}

