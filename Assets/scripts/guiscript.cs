using UnityEngine;
using System.Collections;

public class guiscript : MonoBehaviour
{
    public Texture aTexture;

    void OnGUI()
    {
        if (!aTexture)
        {
            Debug.LogError("Assign a Texture in the inspector.");
            return;
        }

        GUI.DrawTexture(new Rect(20, 80, 40, 15), aTexture, ScaleMode.ScaleToFit, true, -05.0F);
    }

}

