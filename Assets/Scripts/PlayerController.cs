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
    public float speed;
    public Boundary boundary;

    void Start()
    {
        moverComponent.speed = speed;
    }

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), transform.position.z);
        moverComponent.direction = direction;

        float x = Mathf.Clamp(transform.position.x, boundary.xMinimun, boundary.xMaximun);
        float y = Mathf.Clamp(transform.position.y, boundary.yMinimun, boundary.yMaximun);
        transform.position = new Vector3(x, y);
    }
}
