using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float minDelay, maxDelay;
    float nextLaunchTime;
    public int numberEnemy = 5;
    public GameObject menuWin;
    public Text textEnemy;
    void Update()
    {
        textEnemy.text = ($"Enemy {numberEnemy}");
        int positionX = Random.Range(-2, 8);
        if (Time.time > nextLaunchTime && numberEnemy >= 0)
        {
            Instantiate(enemy, new Vector2(positionX, transform.position.y), Quaternion.identity);
            nextLaunchTime = Time.time + Random.Range(minDelay, maxDelay);
        }
        if (numberEnemy <= 0)
        {
            menuWin.SetActive(true);
            Time.timeScale = 0;
        }
    }
}