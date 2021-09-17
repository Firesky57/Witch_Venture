using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchMovement : MonoBehaviour
{
    private Camera mainCamera;
    private Rigidbody2D rb;
    [SerializeField]private float xMargin=2;
    [SerializeField]private float witch_speed=2;

    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
        mainCamera=Camera.main;
    }
    void Start()
    {
       
    }

    public float ms=6;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up*ms*Time.deltaTime);
        }
    }
    void Update()
    {
        int dirX=0;

        if(Application.isEditor)
        {
            if(Input.GetKey(KeyCode.D))
            {
                dirX=1;
                transform.rotation=Quaternion.Euler(0,0,-30);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                dirX=-1;
                transform.rotation=Quaternion.Euler(0,0,30);
            }
        }
        else
        {
         if(Input.touches.Length>0)
          {
            Vector3 touchPosition=Input.touches[0].position;
            touchPosition=mainCamera.ScreenToWorldPoint(touchPosition);

            if(touchPosition.x>0)
            {
                dirX=1;
                transform.rotation=Quaternion.Euler(0,0,-30);
            }
            else
            {
                dirX=-1;
                transform.rotation=Quaternion.Euler(0,0,30);
            }

          }
        }

        rb.velocity=new Vector2(dirX*witch_speed,0);
        float posX=transform.position.x;
        posX=Mathf.Clamp(posX,-xMargin,xMargin);
        transform.position=new Vector3(posX,transform.position.y,transform.position.z);
    }
}
