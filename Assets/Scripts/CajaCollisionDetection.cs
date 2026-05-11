using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public UiManager UiMgr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)
    {
        Debug.Log("Collision con: " + col.gameObject.name);
        if(col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            UiMgr.Txt_perdiste.gameObject.SetActive(true);
        }
        else if(col.gameObject.CompareTag("Piso"))
        {
            float PosicionAleatoria = Random.Range(-2f, 2f);
            transform.position = new Vector3(PosicionAleatoria, 6, 0);
            GetComponent<CajaMovement>().speed += 1f;
        }
    }
}
