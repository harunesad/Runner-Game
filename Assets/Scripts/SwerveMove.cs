using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMove : MonoBehaviour
{
    private SwerveSystem swerveSystem;
    [SerializeField] private float swerveSpeed = 5f;
    public Canvas canvas;
    private void Awake()
    {
        swerveSystem = GetComponent<SwerveSystem>();
    }
    private void Update()
    {
        CanvasEnabled();
    }
    public void Move(bool run)
    {
        if (run == true)
        {
            float swerveAmount = Time.deltaTime * swerveSpeed * swerveSystem.MoveFactorX;
            transform.Translate(x: swerveAmount, y: 0, z: 0);
        }
    }
    public void CanvasEnabled()
    {
        if (canvas.GetComponent<Canvas>().enabled == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                canvas.GetComponent<Canvas>().enabled = false;
            }
        }
        if (canvas.GetComponent<Canvas>().enabled == false)
        {
            Move(true);
        }
    }
}
