using System.Collections;
using UnityEngine;

public class ControllerEnemy : MonoBehaviour
{
    public float speed;
    public float healtEnemy;
    public Animator animatorDead, animBomb;
    private ControllerPlayer player;
    private SpawnEnemy spawnEnemy;
    void Start()
    {
        player = FindObjectOfType<ControllerPlayer>();
        spawnEnemy = FindObjectOfType<SpawnEnemy>();
    }
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        if (transform.position.y < -10)
        {
            speed = 0;
            animBomb.SetTrigger("Bom");
            animatorDead.SetTrigger("Dead");
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
        player.healtPlayer--;
        spawnEnemy.numberEnemy--;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rifle"))
        { healtEnemy--; }
        if (other.CompareTag("Barrier") || healtEnemy == 0)
        {
            speed = 0;
            animBomb.SetTrigger("Bom");
            animatorDead.SetTrigger("Dead");
            StartCoroutine(Wait2());
        }
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
        spawnEnemy.numberEnemy--;
    }
}