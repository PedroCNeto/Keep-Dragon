using UnityEngine;

public class DragonScript : MonoBehaviour
{
    Vector3 originalSize;
    public Animator animator;
    void Start()
    {
        originalSize = transform.localScale;
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    public void inspiration()
    {
        animator.SetTrigger("Inspiration");
        animator.ResetTrigger("CloseEyes");
    }
    public void expiration()
    {
        animator.SetTrigger("Expiration");
        animator.ResetTrigger("OpenEyes");
    }

    public void closeEyes()
    {
        animator.SetTrigger("CloseEyes");
        animator.ResetTrigger("Expiration");
    }

    public void openEyes()
    {
        animator.SetTrigger("OpenEyes");
        animator.ResetTrigger("Inspiration");
    }


}
