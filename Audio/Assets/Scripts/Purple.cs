﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Purple : MonoBehaviour
{
    public GameObject PurpleText;
    private int purpleCounter;

    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {





    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            purpleCounter++;
            PurpleText.GetComponent<Text>().text = "Purple: " + purpleCounter;

            audioSource.Play();
        }
    }
}
