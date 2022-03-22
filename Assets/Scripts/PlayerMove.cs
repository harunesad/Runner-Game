using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public Canvas canvas;
    public Text level;
    [SerializeField]private Animator animator;
    private bool running = true;
    public float levelNumber;
    void Update()
    {
        MoveForward(true);
        if (transform.position.x < -3.75f)
        {
            transform.position = new Vector3(-3.75f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 3.75f)
        {
            transform.position = new Vector3(3.75f, transform.position.y, transform.position.z);
        }
    }
    public void MoveForward(bool run)
    {
            if (canvas.GetComponent<Canvas>().enabled == false)
            {
                if (run == true)
                {
                    animator.SetFloat("Speed", 3);
                    if (this.gameObject.transform.position.z < Level.forwardSide)
                    {
                        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
                        level.text = "Level 1";
                }
                    else if (this.gameObject.transform.position.z > Level.forwardSide)
                    {
                        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
                        level.text = "Level 2";
                }
                }
            }
    }
}
