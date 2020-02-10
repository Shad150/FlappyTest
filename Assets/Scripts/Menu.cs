using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public GameObject menu;
    public Animator menuAnimator;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Time.timeScale = 1;
       // menu.SetActive(false);
        menuAnimator.SetTrigger("BotonPlayPulsado");
    } 

    public void Pause()
    {
        Time.timeScale = 0;
        
    }

}
