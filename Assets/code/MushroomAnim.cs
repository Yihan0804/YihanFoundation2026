using UnityEngine;

public class MushroomAnim : MonoBehaviour
{
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        Debug.Log("Click");
        animator.SetTrigger("Click");
       
    }
}
