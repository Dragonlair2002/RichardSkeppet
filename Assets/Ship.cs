using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [Range(-720, 720)]
    public float RotationSpeedRight;
    public SpriteRenderer rend;
    public Transform other;
    public Color NewColor;
    public float Timer;
    public int X;
    public float Speed;
    public float RotationSpeedLeft;
    float ScreenPositionX;
    float ScreenPositionY;
    

    // Use this for initialization
    void Start()
    {
        //När man startar spelet så ska spriten/skeppet starta i en random plast inom kamran.
        transform.position = new Vector3(Random.Range(-17.79f, 17.80f), Random.Range(-10f, 10f), transform.position.z);
        //Hastigheten ändras för varje gång man startar spelet.
        Speed = (Random.Range(1, 21));
    }

    // Update is called once per frame
    void Update()
    {
        //Hastigheten på spriten/skeppet. Och hastigheten ändras inte beroende på FPS.
        transform.Translate(0, Speed * Time.deltaTime, 0, Space.Self);
        //När man trycker på D så ska något hända.
        if (Input.GetKey(KeyCode.D))
        {
            //Om man trycker på D så en ny färg andras på spriten/skeppet.
            rend.color = NewColor;
            //Att spriten/skeppet ska ändra till blå när man trycker på D.
            rend.color = new Color(0f, 0f, 255f);
            //Att spriten/skeppet ska vrida sig i Z axel medsos.
            transform.Rotate(0, 0, -RotationSpeedRight * Time.deltaTime);
            //Hur snabbt spriten/skeppet ska vridas.
            transform.Translate(2f * Time.deltaTime, 0, 0, Space.Self);
        }
        //Om man trycker på A så ska något hända.
        if (Input.GetKey(KeyCode.A))
        {
            //När man trycker på A så ska den ändra färg.
            rend.color = NewColor;
            //Att spriten/skeppet ska ändra till grön när man trycker på A.
            rend.color = new Color(0f, 255f, 0f);
            //Att spriten/skeppet ska vrida sig i Z axel motsos.
            transform.Rotate(0, 0, RotationSpeedLeft * Time.deltaTime);
            //Hur snabbt spriten/skeppet ska vridas.
            transform.Translate(2f * Time.deltaTime, 0, 0, Space.Self);
        }
        //Om man trycket på S så ska något hända.
        if (Input.GetKeyDown(KeyCode.S))
        {
            //När man trycker på S så ska hastigheten på högra vridningen bli dubbelt så långsam.
            RotationSpeedRight = (RotationSpeedRight / 2);
            //När man trycker på S så ska hastigheten på vänstra vridningen bli dubbelt så långsam.
            RotationSpeedLeft = (RotationSpeedLeft / 2);
            //Att hastigheten på spriten/skeppet ska bli dubblet så långsam.
            Speed = (Speed / 2);
        }
        //När man tar upp fingret från S så ska något hända.
        if (Input.GetKeyUp(KeyCode.S))
        {
            //När man släpper S så blir hastigheten när man vrider åt höger bli dubbelt så snabbt.
            RotationSpeedRight = (RotationSpeedRight * 2);
            //När man släpper S så blir hastigheten när man vrider åt höger bli dubbelt så snabbt.
            RotationSpeedLeft = (RotationSpeedLeft * 2);
            //När man släpper S så blir hastigheten dubbelt så snabbt.
            Speed = (Speed * 2);
        }
        //Variablen "Timer" börjar med 0 sekunder, sen så adderas Timer med "Time.deltaTime" och det menas att Timer adderas med sekunder med FPS.
        Timer += Time.deltaTime;
        //Om Timer är Större än variablen "X" så ska något hända.
        if (Timer > X)
        {
            //Variablen "X" är lika med X plus ett.
            X = X + 1;
            //Detta visas i Console i Unity att Timer: är X och X visas sekunder så att man kan se hur långt man har spelat.
            Debug.Log(string.Format("Timer: {0}", X));
        }
        //Om man trycker på space så ska något hända.
        if (Input.GetKey(KeyCode.Space))
        {
            //Om man trycker på Space så ska ny färg andras på spriten/skeppet.
            rend.color = NewColor;
            //Att spriten/skeppet ska ändra till en random färg när man trycker på Space.
            rend.color = new Color(Random.Range(0f, 2f),Random.Range(0f, 2f), Random.Range(0f, 2f));
        }
        // Om spriten/skeppet blir mindre än -17.79 på X axeln så ska något hända.
        if (transform.position.x < -17.79f)
        {
            //När spriten/skeppet blir mindre än -17.79 på X axeln så ska den teleporteras till 17.79 på X axeln.
            transform.position = new Vector3(17.79f, transform.position.y, transform.position.z);
        }
        //Om spriten/skeppet blir större än 17.79 på X axeln så ska något hända.
        if (transform.position.x > 17.79f)
        {
            //När spriten/skeppet blir större än 17.79 på X axeln så ska den teleporteras till -17.79 på X axeln.
            transform.position = new Vector3(-17.79f, transform.position.y, transform.position.z);
        }
        //Om spriten/skeppet blir mindre än -10 på Y axeln så ska något hända.
        if (transform.position.y < -10f)
        {
            //När spriten/skeppet blir mindre än -10 på Y axeln så ska den teleporteras till 10 på Y axeln.
            transform.position = new Vector3(transform.position.x, 10f, transform.position.z);
        }
        // Om spriten/skeppet blir större än 10 på Y axeln så ska något hända.
        if (transform.position.y > 10f)
        {
            //När spriten/skeppet blir större än 10 så ska den teleporteras till -10 på Y axlen.
            transform.position = new Vector3(transform.position.x, -10f, transform.position.z);
        }

    } 
}
