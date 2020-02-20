using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float Velocidade;
    private float Vertical;
    private float horizontal;
    public FixedJoystick Joystick;

    void Update()
    {

        horizontal = Joystick.Horizontal;
        Vertical = Joystick.Vertical;
        transform.Translate(new Vector3(horizontal, 0, Vertical) * Velocidade * Time.deltaTime);
  
    }
}
