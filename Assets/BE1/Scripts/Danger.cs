using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Danger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && GameManager.isHit == false)
        {
            //점수얻기
            other.SendMessage("PlaySound", Sounder.Sfx.Hit);
            Hit();
            other.transform.position = Vector3.up;
            Debug.Log(GameManager.health);
            //플레이어 원위치
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameManager.isHit = false;
    }

    void Hit()
    {
        GameManager.isHit = true;
        GameManager.health -= 1;
        if (GameManager.health <= 0)
        {
            BGMManager bgm = FindObjectOfType<BGMManager>();
            Destroy(bgm.gameObject);
            SceneManager.LoadScene("End");
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