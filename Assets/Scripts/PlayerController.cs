using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary {
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour
{
    public Boundary boundary;
    public float speed = 1;

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, transform.position.z);
        
        float x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
        float y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
        transform.position = new Vector3(x, y);
    }
}
