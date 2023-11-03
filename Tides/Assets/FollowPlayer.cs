using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Component that stores the location of the player
    public Transform Player;
    public Transform tf;
    private int offset = 5; 


    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.magnitude - tf.transform.position.magnitude >= offset)
        {

        }
    }
}
