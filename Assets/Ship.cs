using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [Range(-720, 720)]
    public float RotationSpeed;
    public SpriteRenderer rend;
    public Transform other;
    public Color NewColor;
    public float Timer;
    public int X = 1;
    public float Speed = 20;

    // != inte lika med
    // == lika med
    // > större än
    // < mindre än
    // >= större eller lika med
    // <= mintre eller lika med
    // && och (shift 6)
    // || eller (alt gr <)


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0, Space.Self);

        if (Input.GetKey(KeyCode.D))
        {
            rend.color = NewColor;
            rend.color = new Color(0f, 0f, 255f);
            transform.Rotate(0, 0, -RotationSpeed * Time.deltaTime);
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rend.color = NewColor;
            rend.color = new Color(0f, 255f, 0f);
            transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            RotationSpeed -= 125;
            Speed -= 10;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            RotationSpeed += 125;
            Speed += 10;
        }
        if (Timer > X)
        print("Timer" + X);
        X = X + 1;

    }
}
