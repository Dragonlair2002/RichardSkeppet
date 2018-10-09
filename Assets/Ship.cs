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
    public int X;
    public float Speed = 20;
    public float Left = 150;


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
        transform.Translate(0, Speed * Time.deltaTime, 0, Space.Self);
        //Detta betyder om man trycker på D så ska något hända.
        if (Input.GetKey(KeyCode.D))
        {
            //Om man trycker på D så en ny färg andras på spriten/skeppet.
            rend.color = NewColor;
            //Att spriten/skeppet ska ändra till grön när man trycker på D.
            rend.color = new Color(0f, 0f, 255f);
            //Att spriten/skeppet ska vrida sig i z axel medsos.
            transform.Rotate(0, 0, -RotationSpeed * Time.deltaTime);
            //Detta betyder hur snabbt den ska vrida.
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
        //Om man trycker på A så ska något hända.
        if (Input.GetKey(KeyCode.A))
        {
            //När man trycker på A så ska den ändra färg.
            rend.color = NewColor;
            //Detta betyder vilken specifik färg spriten/skeppet ska ändras till.
            rend.color = new Color(0f, 255f, 0f);
            //Att spriten/skeppet ska vrida sig i z axel motsos.
            transform.Rotate(0, 0, Left * Time.deltaTime);
            //HUr snabbt spriten/skeppet ska vridas.
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
        //Om man trycket på S så ska något hända.
        if (Input.GetKeyDown(KeyCode.S))
        {
            //När man trycker på S så ska hastigheten på vridningen bli långsammare.
            RotationSpeed -= 125;
            //Att hastigheten på spriten/skeppet ska bli långsammare.
            Speed -= 10;
        }
        //När man tar upp fingret från S så ska något hända.
        if (Input.GetKeyUp(KeyCode.S))
        {
            //När man släpper S så blir hastigheten när man vrider sig snabbare.
            RotationSpeed += 125;
            //När man släpper S så blir hastigheten snabbare.
            Speed += 10;
        }
        //Variablen "Timer" börjar med 0 sekunder men men "Time.deltaTime" så adderas Timer med sekunder i riktiga sekunder.
        Timer += Time.deltaTime;
        //Om Timer är Större än variablen "X" så ska något hända.
        if (Timer > X)
        {
            //Variablen "X" är lika med X plus ett.
            X = X + 1;
            //Detta visas i Console i Unity att Timer: är X och X visas sekunder så att man kan se hur långt man har spelat.
            Debug.Log(string.Format("Timer: {0}", X));
        }
        if (Input.GetKey(KeyCode.Space))
        {
            

        }
    } 
}
