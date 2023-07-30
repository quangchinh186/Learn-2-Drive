//Attach this script to any GameObject in your scene to spawn a cube and change the material color to a custom color
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   void Start()
   {
       // Create a new cube primitive to set the color on
       GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);

       // Get the Renderer component from the new quad
       var quadRenderer = quad.GetComponent<Renderer>();

        // Create a new RGBA color using the Color constructor and store it in a variable
        Color customColor = new Color(0.4f, 0.9f, 0.7f, 1.0f);

       // Call SetColor using the shader property name "_Color" and setting the color to the custom color you created
       quadRenderer.material.SetColor("_Color", customColor);
   }

   void Update()
   {

   }
}