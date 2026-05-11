using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI Txt_perdiste;
    public TextMeshProUGUI Txt_tiempo;
    
    // Start is called before the first frame update
    void Start()
    {
        Txt_perdiste.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float Tiempo = Time.time;
        Txt_tiempo.text = ("Tiempo: " + Tiempo.ToString("F2"));
    }
}
