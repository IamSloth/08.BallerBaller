using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 inputVec;
    public float movePower;
    public float jumpPower;
    public bool isGround;

    Rigidbody rigid;
    private FixedJoystick joy;
    
    // Start is called before the first frame update

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        joy = FindObjectOfType<FixedJoystick>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //inputVec.x = Input.GetAxisRaw("Horizontal");
        //inputVec.z = Input.GetAxisRaw("Vertical");
        //bool isJump = Input.GetButtonDown("Jump");
        inputVec.x = joy.Horizontal;
        inputVec.z = joy.Vertical;
    }
    
    public void Jump()
    {
        if (isGround)
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            SendMessage("PlaySound",Sounder.Sfx.Jump);
        }
    }

    private void FixedUpdate()
    {
        if (isGround)
        {
            rigid.AddForce(inputVec * movePower);    
        }
        
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        isGround = true;
    }

    private void OnCollisionExit(Collision other)
    {
        isGround = false;
    }
}
