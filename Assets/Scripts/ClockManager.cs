using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClockManager : MonoBehaviour
{

    private  TextMeshProUGUI _textmeshProgui;
    public AudioSource audio1;
    public AudioSource audio2;
    private bool AudioAlternate = false;
    public int wait = 1;
    public AudioClip clockTick;
    // Start is called before the first frame update
    void Start()
    {
        
        _textmeshProgui = FindObjectOfType<TextMeshProUGUI>();
        StartCoroutine("ClockGO");

    }

    // Update is called once per frame
    void Update()
    {

       

       
    }
    IEnumerator ClockGO()
    {
        while (true)
        {
             if(AudioAlternate)
             {
                 audio1.Play();
                 AudioAlternate = false;
                Debug.Log("play 1");
             }
             else
             {
                 AudioAlternate = true;
                 audio2.Play();
                Debug.Log("play 2");
             }
           
          
            timeCreation t = new timeCreation(DateTime.Now);

             _textmeshProgui.SetText(t.ReturnTimingString.ToString());

            yield return new WaitForSeconds(wait);
        }
    }
    
}
