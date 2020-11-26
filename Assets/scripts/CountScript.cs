using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScript : MonoBehaviour{

    public static int CountValue;
    Text count;
    


    // Start is called before the first frame update
    void Start()
    {
        count = GetComponent<Text> ();
        count.text = "I needed" + " " + CountValue + " " + "tries";

  

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
