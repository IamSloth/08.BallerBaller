using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameManager : MonoBehaviour
{
    [Range(1, 144)]
    public int rate = 60;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = rate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
