using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Component that stores the location of the player
    public Transform Player;
    public Transform tf;
    private Vector3 velocity = Vector2.zero;
    public float SmoothTime = 0.3f;
    private Vector3 offset; 


    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        offset = Player.transform.position - tf.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = Player.position + offset; 
        transform.position = Vector3.SmoothDamp(tf.position, targetPosition, ref velocity, SmoothTime);
        
    }
}
