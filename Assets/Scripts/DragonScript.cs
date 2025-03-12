using UnityEngine;

public class DragonScript : MonoBehaviour
{

    public GameObject GameController;

    Vector3 originalSize;


    void Start()
    {
        originalSize = transform.localScale;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            inspiration();
        }
        else
        {
            expiration();
        }
    }

    void inspiration()
    {
        if(transform.localScale.x < 3f)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1.2f, 1.2f, 1.2f), (Time.deltaTime * 0.5f));
        }
    }

    void expiration()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, originalSize, (Time.deltaTime * 0.5f));
    }
}
