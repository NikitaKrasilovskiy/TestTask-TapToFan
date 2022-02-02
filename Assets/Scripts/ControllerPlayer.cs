using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ControllerPlayer : MonoBehaviour
{
    private Animator animator;
    public float speed;
    public float healtPlayer;
    public Text textHealt;
    public GameObject menuDead;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        textHealt.text = ($"Healt {healtPlayer}");
        float dir = Input.GetAxisRaw("Horizontal");
        if (dir != 0)
        {
            animator.SetTrigger("Move");
            if (dir > 0 && transform.position.x < 8)
            {transform.Translate(speed * Time.deltaTime, 0, 0);}
            if (dir < 0 && transform.position.x > -2.5)
            { transform.Translate(-speed * Time.deltaTime, 0, 0); }
        }

        if (healtPlayer <= 0)
        {
            animator.SetTrigger("Dead");
            StartCoroutine(Wait());
        }
        IEnumerator Wait()
        {
            yield return new WaitForSeconds(1.9f);
            Destroy(this.gameObject);
            yield return new WaitForSeconds(1f);
            menuDead.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
