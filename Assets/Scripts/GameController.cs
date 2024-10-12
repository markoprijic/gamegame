using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector2 startPos;
    [SerializeField] GameObject active;
    [SerializeField] GameObject inactive;
    private bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if (active.activeInHierarchy == true)
        {
            isActive = true;
        }

        else isActive = false;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle")) 
        {
            if (isActive == false)
            {
                SwitchActiveScene();
                Die();
            }   
            else
            {
                Die();
            }
        }
    }

    void SwitchActiveScene()
    {
        active.SetActive(true);
        inactive.SetActive(false);
    }
    void Die()
    {
        Respawn();

    }

    void Respawn()
    {
        transform.position = startPos;
    }
}
