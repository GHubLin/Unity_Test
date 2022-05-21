using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coincollider : MonoBehaviour
{
    public Text textcoin;
    public int textcount;


    private void OnTriggerEnter(Collider coin)
    {
        if (coin.tag == "coin")
        {
            Debug.Log("dadsda");
            textcount++;
            textcoin.text = textcount.ToString();
            Destroy(coin.gameObject);

        }
        
    }
}
