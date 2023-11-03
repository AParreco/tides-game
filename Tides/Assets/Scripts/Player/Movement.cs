using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs; 

public class Movement : MonoBehaviour
{
    public int movementSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    public IEnumerator DashTimer()
    {
        yield return new WaitForSeconds(2); 
        movementSpeed = 15; 

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed); 
        // add a small dash in speed after walking for a few seconds
        if(horizontal > 0 || vertical > 0)
        {
            StartCoroutine(DashTimer()); 
        }
        else
        {
            StopCoroutine(DashTimer());
            movementSpeed = 10;
        }


    }
}
