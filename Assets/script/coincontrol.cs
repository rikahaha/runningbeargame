using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincontrol : MonoBehaviour

{
    public static int coinCount = 0;

    void Start()
    {
        
    }
    void Update()
    {

    }

private void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(gameObject);
        coinCount+=1;

    }


    

}
