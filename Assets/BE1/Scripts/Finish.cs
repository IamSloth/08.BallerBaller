using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && GameManager.isFinish == false)
        {
            GameManager.Next();
            other.transform.position = Vector3.up;
            Debug.Log(GameManager.level);
            other.SendMessage("PlaySound",Sounder.Sfx.Next);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
