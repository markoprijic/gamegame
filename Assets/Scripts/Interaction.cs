using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactionKey;
    public GameObject active;
    public GameObject inactive;

    
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactionKey))
            {
                if (active.activeInHierarchy == true)
                {
                    active.SetActive(false);
                }
                else
                {
                    active.SetActive(true);
                }

                if (inactive.activeInHierarchy == false)
                {
                    inactive.SetActive(true);
                }
                else
                {
                    inactive.SetActive(false);
                }

            }
            

            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
}
