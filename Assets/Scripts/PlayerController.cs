using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMinimun, xMaximun, yMinimun, yMaximun;
}

public class PlayerController : MonoBehaviour
{
    public Mover moverComponent;
    public Boundary boundary;
    public float speed = 1;

    void Update()
    {
        Vector3 displacement = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, transform.position.z);
        moverComponent.DoMove(displacement);

        float x = Mathf.Clamp(transform.position.x, boundary.xMinimun, boundary.xMaximun);
        float y = Mathf.Clamp(transform.position.y, boundary.yMinimun, boundary.yMaximun);
        transform.position = new Vector3(x, y);
    }
}
