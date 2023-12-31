using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float displacement;
    public Rigidbody2D warrior;
    Vector2 initial;
    public Animator animator;
    public float jump; // for jump

    void Start()
    {
        warrior = GetComponent<Rigidbody2D>();
        initial= warrior.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetKey(KeyCode.RightArrow))){
                animator.SetFloat("speed",1.0f);
                initial.x=initial.x+displacement;
                
        }
        
        if (Input.GetKey(KeyCode.Space)){
            //for jump
            warrior.AddForce(new Vector2(warrior.velocity.x,jump));
            
        }
       
        if (!Input.anyKey)
            animator.SetFloat("speed",0);
        

            

        warrior.MovePosition(initial);
    }
}
