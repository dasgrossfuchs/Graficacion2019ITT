using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public CharacterController cctrl;
    public int jmpframecount = 0, jmpcnt = 0;
    public float speed = 0.5f;
    public float gravity =9.8f;
    public float jump = 15f;
    
    
    // Update is called once per frame
    void Update()
    {
        float t = 1f;
        Vector3 move = new Vector3(0, 0, 0);
        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");
        move.y = move.y-gravity;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jmpframecount == 0) jmpframecount = 15;
            
            
            
        }
        if (jmpframecount >= 1)
        {
            move.y = move.y + 1f;
            jmpframecount -= 1;
        }
        move = move * speed;
        cctrl.Move(move);
    }
}
