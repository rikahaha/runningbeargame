using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgcontrol : MonoBehaviour
{
    // speed
    public float Speed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        if (playercontrol.HP == 0)
        {
            Speed=0;
        }
        //background move
        foreach (Transform tran in transform )
        {
            //direction
            Vector3 pos = tran.position;
            pos.x -= Speed * Time.deltaTime;
            //
            if (pos.x <-22f)
            {
                //picmovetoright
                pos.x += 22f * 2;
            }
            tran.position = pos;
        }
    }
}
