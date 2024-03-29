using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature1stEncounter : MonoBehaviour
{
    public Transform point;
    public float speed = 5;
    public float smooth = 5;
   private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

   private void Update()
    {
        //rotates object smoothly to target
        var rotation = Quaternion.LookRotation(point.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * smooth);

        transform.Translate(Vector3.left * speed * Time.deltaTime);
        animator.SetBool("move", true);

        Destroy(gameObject, 3f);
    }
}
