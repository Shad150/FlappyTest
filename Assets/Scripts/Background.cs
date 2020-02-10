﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    private Material myMaterial;
    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;                                                             //Guarda el material del objeto
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.mainTextureOffset =  myMaterial.mainTextureOffset + Vector2.right * 0.5f * Time.deltaTime;        //mainTextureOffset es el offset de la textura
    }
}
