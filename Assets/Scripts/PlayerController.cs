using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int posicionActual = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow) && posicionActual > -1){
            transform.Translate(-2, 0, 0);
            posicionActual --;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && posicionActual < 1){
            transform.Translate(2, 0, 0);
            posicionActual ++;
        }
    }
}
