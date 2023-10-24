using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI

public class boxScript : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rd;
    public static int count;
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void onTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            gameObject.SetActive(false);
            count++;
        }
    }
}
