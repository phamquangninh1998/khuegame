using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = player.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        MoveToPlayer();
    }

   void MoveToPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, player.position-offset, 0.2f);
    }
}
