using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Transform transformplayer;
    [SerializeField] private Transform TransformBallPosition;
    private bool StickToPlayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (!StickToPlayer) {
            float distanceToPlayer = Vector3.Distance(transformplayer.position, transform.position);
            if (distanceToPlayer < 0.5)
            {
                StickToPlayer = true;
            }
            else
            {
                transform.position = TransformBallPosition.position;
            }
        }
    }
    
}
