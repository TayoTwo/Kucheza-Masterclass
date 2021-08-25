using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{

    //Boolean
    public bool checkboxFilled;
    //Integer
    public int option;

    public int x;
    public int y;
    //Float i.e a decimal number with a certain number of poitns afterwards
    public float z;

    // Start is called before the first frame update
    void Start(){
        
        if(checkboxFilled){

            Debug.Log("Checkbox is filled");

        } else {

            Debug.Log("Checkbox is not filled");

        }

        switch(option){

            case 0:

                Debug.Log("Case 0");
                break;

            case 1:

                Debug.Log("Case 1");
                break;

            case 2:

                Debug.Log("But also case 2!");
                break;

            default:

                Debug.Log("Didn't select ");
                break;

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /////////////////CUSTOM FUNCTIONS////////////////////

    void SayHello(){

        Debug.Log("Hello!");

    }

    int Addition(int a, int b){

        return a + b;

    }

    bool IsTheComputerOn(){

        return true;

    }

    float sqr(float x){

        return Mathf.Sqrt(x);

    }

}
