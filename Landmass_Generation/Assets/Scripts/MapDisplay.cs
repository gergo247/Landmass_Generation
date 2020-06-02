using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    public Renderer textureRender;

    public void DrawTexture(Texture2D texture)
    {
       
        //this way we can view texture in scene mode too
        textureRender.sharedMaterial.mainTexture = texture;
        //set size equal to map
        textureRender.transform.localScale = new Vector3(texture.width, 1, texture.height);

    }
}
