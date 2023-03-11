using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Transform cam;
    CharacterController control;
    private Animator anim;
    public float speedCam = 110.5f;
    public float speedMoving = 8.0f;
    public float speedRotation = 90.6f;
    public float camRotation = 0f;
    public float x, y, mx, my;

    public Rigidbody rb;
    public float forceJump = 8.0f;
    public bool icanJump;


    public float posicionY = 1.0f;
    void Start()
    {

        icanJump = false;
        
        anim = GetComponent<Animator>();
        cam = transform.GetChild(0).GetComponent<Transform>();
        control = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate(){

        transform.Rotate(new Vector3(0, mx, 0) * speedCam * Time.deltaTime);
        transform.Rotate(0, x * Time.deltaTime * speedRotation, 0);
        
        transform.Translate(0, 0, y* Time.deltaTime * speedMoving);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 posicionActual = transform.position;
        posicionActual.y = posicionY;
        transform.position = posicionActual;

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("X", x);
        anim.SetFloat("Y", y);


        if(Input.GetKeyDown(KeyCode.Space))
            icanJump = true;
            if(icanJump){
            {
                anim.SetBool("Jump",true);
                rb.AddForce(new Vector3(0, forceJump, 0),ForceMode.Impulse);
            }
            //anim.SetBool("touchFloor", true);
            //anim.SetBool("Jump",false);
        }
        else{
            Iamfalling();
        }
    }
    public void Iamfalling()
    {
        anim.SetBool("touchFloor", false);
        anim.SetBool("Jump",false);
    }
}
