using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{

    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "score : " + coincontrol.coinCount.ToString();
        if (playercontrol.HP == 0)
        {
            
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("SampleScene");
                playercontrol.HP = 1;
                coincontrol.coinCount = 0;
            }
        }
    }
}
