using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol2D : MonoBehaviour
{
    public float runSpeed = 40f;
    [SerializeField]
    float horizontalMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }
}
