using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Movement movement3D;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        movement3D = GetComponent<Movement>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        movement3D.MoveTo(new Vector3(x, 0, z));

        animator.SetFloat("Speed", z);

        Vector3 dir = new Vector3(x, 0, z);

        dir = Camera.main.transform.TransformDirection(dir);
    }
}
