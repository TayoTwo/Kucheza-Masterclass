using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    
    public GameObject winScreen;
    
    // Start is called before the first frame update
    void Start(){

        winScreen = GameObject.FindGameObjectWithTag("WinScreen");
        winScreen.SetActive(false);
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Player"){

            winScreen.SetActive(true);

        }

    }
}
