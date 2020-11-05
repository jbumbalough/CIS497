using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayWave : MonoBehaviour
{
    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox.GetComponent<Text>();
        textbox.text = "Wave: 0";
        
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Wave " + SpawnManager.waveNumber;
    }
}
