using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundcontrol : MonoBehaviour
{
    // speed
    public float Speed = 2f;
    //random ground
    public GameObject[] GroundPrefabs;


    // Update is called once per frame
    void Update()
    {
        if (playercontrol.HP == 0)
        {
            Speed = 0f;
        }
        else {
            //background move
            foreach (Transform tran in transform)
        {
            //direction
            Vector3 pos = tran.position;
            pos.x -= Speed * Time.deltaTime;
            //
            if (pos.x < -22f)
            {
                //new ground
                Transform newTrans = Instantiate(GroundPrefabs[Random.Range(0, GroundPrefabs.Length)],transform).transform;

                //new ground position
                Vector2 newPos = newTrans.position;
                newPos.x = pos.x + 22f * 2;
                newTrans.position = newPos;
                Destroy(tran.gameObject);
                //picmovetoright
                pos.x += 22f * 2;
            }
            tran.position = pos;
        }
        }
    }
}
