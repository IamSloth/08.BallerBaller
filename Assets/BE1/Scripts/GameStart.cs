using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    public void OnSelect(Material mat)
    {
        GameManager.skin = mat;
        GameManager.GameStart();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Player"))
        {
            MeshRenderer mesher = GetComponent<MeshRenderer>();
            mesher.material = GameManager.skin;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
