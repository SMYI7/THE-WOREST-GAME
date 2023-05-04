using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Movement: MonoBehaviour
{
    public float WhereTocCheck;
    public Transform GroundCheck  ;
    public LayerMask GroundMask;
    private bool Ground;
    public int MaxJumps = 1;
    public int CurrentJumps = 1;
    public int MaxSpeed = 0;
    public float CurrentSpeed = 0;
    public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
      // if (Input.GetAxis("Jump") | CurrentJumps > 0)
        {

        }

        if (Ground == true)
        {
            CurrentJumps = MaxJumps;
        }
       
    }
    void FixedUpdate()
    {
        Ground = Physics2D.OverlapCircle(GroundCheck.position, WhereTocCheck, GroundMask);
    }
}
