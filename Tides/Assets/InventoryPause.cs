using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPause : MonoBehaviour
{
    private bool isPaused;
    public GameObject inventory; 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && !isPaused)
        {
            inventory.SetActive(true);
            isPaused = true; 
        }
        else if(Input.GetKeyDown(KeyCode.E) && isPaused)
        {
            inventory.SetActive(false);
            isPaused = false; 
        }
    }
}
