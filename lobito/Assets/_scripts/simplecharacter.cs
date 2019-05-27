using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplecharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }
    public CharacterController ctrll;
    //public Transform chartrans;
    public float speed =15f;
    public float jumpspd = 5f;
    public float gravy = 20f;
    float yvel = 0;
    // Update is called once per frame
    void Update()
    {
        float t =Time.fixedDeltaTime;
        Vector3 movement = new Vector3(0,0,0);
        movement.x = Input.GetAxis("Horizontal");
        //movement.z = Input.GetAxis("Vertical"); //dogemode
        yvel = (ctrll.velocity.y) - (gravy * t) ;
        if (Input.GetKeyDown(KeyCode.Space))
        {
             yvel += 20f;
        }
        
        movement = movement * speed*t;
        
        movement.y = yvel;
        
        ctrll.Move(movement);
    }
    
}
