using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Transform cubeTransform;
    private Renderer cubeRenderer;

    private void Start()
    {
        // Get the Transform component of the cube
        cubeTransform = this.GetComponent<Transform>();
        cubeRenderer = this.GetComponent<Renderer>();
    }

    private void Update()
    {
        // rotar el cubo multiplicando el frame por un valor
        cubeTransform.rotation = Quaternion.Euler(0, Time.time * 30f, 0);

        // cambiamos el color del cubo basado en el frame
        float red = Mathf.Sin(Time.time);
        float green = Mathf.Cos(Time.time);
        float blue = Mathf.Sin(Time.time * 0.7f);
        Color newColor = new Color(red, green, blue);

        cubeRenderer.material.color = newColor;
    }
}
