using UnityEngine;

public class DragonScript : MonoBehaviour
{
    Vector3 originalSize;


    void Start()
    {
        originalSize = transform.localScale;
    }

    void Update()
    {

    }

    public void inspiration()
    {

       transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1f, 1f, 1f), (Time.deltaTime * 0.5f));
    }

     public void expiration()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, originalSize, (Time.deltaTime * 0.5f));
    }
}
