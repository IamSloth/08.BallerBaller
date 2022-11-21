using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(GameManager.level - 1).gameObject.SetActive(true);    
    }
}
