using UnityEngine;
using System.Collections;


public class howtoplay : MonoBehaviour
{
    public float timer = 3.0f;
    void Start()
    {
        Destroy(gameObject, timer);
    }
}