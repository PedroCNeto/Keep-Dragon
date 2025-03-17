using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public DragonScript Dragon;
    public BreathingBar fillBreathBar;
    public RewardController RewardComponent;
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
        if (breathStage == 1)
        {
            fillBreathBar.fillBreathingBar();
        }
        else
        {

            fillBreathBar.emptyBreathingBar();
        }

        if(breathQuantity == 1)
        {
            StartCoroutine(FireEffect());
            RewardComponent.progressColor();
            breathQuantity = 0;
        }
    }


    IEnumerator BreathingCycle()
    {
        while (true)
        {

            Dragon.closeEyes();
            breathStage = 1;
            yield return new WaitForSeconds(0.5f);
            Dragon.inspiration();
            yield return new WaitForSeconds(2f);
            Dragon.openEyes();
            breathStage = 2;
            yield return new WaitForSeconds(0.5f);
            Dragon.expiration();
            yield return new WaitForSeconds(2f);


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
