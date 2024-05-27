using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public GameObject gameover, skor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "grd")
        {
            GameObject.Find("suara jatuh").GetComponent<AudioSource>().Play();
            gameover.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.gameObject.tag == "addScore"){
            GameObject.Find("suara skor").GetComponent<AudioSource>().Play();
            skor.GetComponent<skor> ().score++;
        }
    }
}

