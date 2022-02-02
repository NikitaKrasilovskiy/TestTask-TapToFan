using System.Collections;
using UnityEngine;

public class DestroyBarrier : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            animator.SetTrigger("Destroy");
            StartCoroutine(Wait());
        }
            
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
}
