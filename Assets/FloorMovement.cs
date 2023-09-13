using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    [SerializeField] private float Xmov;
    [SerializeField] private float DestroyTime;


    public int offsetX = 18;

    void Update()
    {
        transform.position -= new Vector3(6 * Time.deltaTime, 0, 0);
        if (transform.position.x <= -offsetX)
        {
            transform.position = new Vector3(offsetX, transform.position.y, 0);
        }
    }
}
