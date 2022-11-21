using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Awake()
    {
        BGMManager[] bgm = FindObjectsOfType<BGMManager>();
        if (bgm.Length == 1)
        {
           DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(bgm[1].gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
