using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaction1 : MonoBehaviour
{
    public GameObject canvas;
    public bool isInRange;
    public KeyCode interactionKey;
    public UnityEvent interactAction;

    
    void Update()
    {
        if (isInRange)
        {
            canvas.SetActive(true);
            
            if (Input.GetKeyDown(interactionKey))
            {
                interactAction.Invoke();

            }
            

            
        }

        else
        {
            canvas.SetActive(false);
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
