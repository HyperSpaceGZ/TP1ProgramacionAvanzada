using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public int jumpforce;
    public bool isjumping = false;
    public Animator Animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isjumping == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpforce, 0);
            isjumping = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Floor")
        {
            isjumping = false;
        }

        if (collision.gameObject.tag == "Cactus")
        {
            SceneManager.LoadScene(0);
        }
    }
}
