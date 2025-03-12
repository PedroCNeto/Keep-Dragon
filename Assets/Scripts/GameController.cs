using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public DragonScript Dragon;
    public BreathingBar fillBreathBar;
    public RockScript Rock;
    public GameObject Fire;

    //1 = Inspirando | 2 = Expirando
    int breathStage = 1;

    int breathQuantity = 0;

    void Start()
    {
        StartCoroutine(BreathingCycle());
    }


    void Update()
    {
        //Respiração manual

        /*if (Input.GetKey(KeyCode.Space))
        {
            Dragon.inspiration();
        }
        else
        {
            Dragon.expiration();
        }*/

        //Respiração automática
        print(breathStage);
        if (breathStage == 1)
        {
            Dragon.inspiration();
            fillBreathBar.fillBreathingBar();
        }
        else
        {
            Dragon.expiration();
            fillBreathBar.emptyBreathingBar();
        }

        if(breathQuantity == 2)
        {
            StartCoroutine(FireEffect());
            Rock.progressColor();
            breathQuantity = 0;
        }
    }


    IEnumerator BreathingCycle()
    {
        while (true)
        {

            breathStage = 1;

            yield return new WaitForSeconds(2.5f);

            breathStage = 2;

            yield return new WaitForSeconds(2.5f);

            breathQuantity += 1;
        }
    }

    IEnumerator FireEffect()
    {
        Fire.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        Fire.SetActive(false);
    }

}
