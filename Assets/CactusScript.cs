using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusScript : MonoBehaviour
{
    public float CactusSpeed;
    public delegate void ScoreEvent();
    public static ScoreEvent scoreevent;

    void Update()
    {
        transform.position -= new Vector3(CactusSpeed * (Time.deltaTime), 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            scoreevent?.Invoke();
        }
    }
}
