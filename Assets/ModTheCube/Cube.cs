using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * TODO: Change the angle at which the cube rotates
 * TODO: Change the cube’s rotation speed
 * TODO: Change the cube’s material color
 * TODO: Change the cube’s material opacity
 * ===== Bonus.
 * TODO: Modify any of the changes above so they change randomly each time the scene is played.
 * TODO: Add extra functionality to the cube. For example, how might you change the color of the cube over time?
 * 
 */
public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float speed = 1.0f;
    private Vector3 scaleChange = new Vector3(0.001f, 0.001f, 0.001f);
    


    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }

    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        transform.Translate(Vector3.right * (Time.deltaTime * speed));
        transform.localScale += scaleChange;
        
    }
}