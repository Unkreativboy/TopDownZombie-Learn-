using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnimationHandler : MonoBehaviour
{
    [SerializeField] private RichAI richAi;

    private Animator animator;
    private int f_moveDirectionX;
    private int f_moveDirectionY;
    private int b_isMoving;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        f_moveDirectionX = Animator.StringToHash("f_moveDirectionX");
        f_moveDirectionY = Animator.StringToHash("f_moveDirectionY");
        b_isMoving = Animator.StringToHash("b_isMoving");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(richAi.velocity);
        animator.SetBool(b_isMoving,richAi.velocity != Vector3.zero);

    }
}
