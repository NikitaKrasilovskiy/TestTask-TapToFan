using UnityEngine;

public class ShotReycast : MonoBehaviour
{
    [SerializeField] private float distance = 10;
    [SerializeField] public GameObject weapon;
    [SerializeField] private LayerMask layerMask;
    public Transform spawnArrows;
    public GameObject rifle;
    float nextLaunchTime;
    public float minDelay, maxDelay;
    private Transform target;
    void Update()
    {
        RaycastHit hit;
        //сам луч, начинается от позиции этого объекта и направлен по оси Z
        Ray ray = new Ray(transform.position, transform.up);
        Physics.Raycast(ray, out hit);

        Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue);
        //если луч с чем-то пересёкся, то..
        if (hit.collider != null)
        {
            //если луч попал в объект с тегом Enemy
            if (hit.collider.CompareTag("Enemy"))
                Debug.Log("Попадаю во врага!!!");
            //если луч попал куда-то в другой объект
            else
                Debug.Log("Путь к врагу преграждает объект: " + hit.collider.name);

            Debug.DrawLine(ray.origin, hit.point, Color.red);
        }
        //    if (Physics2D.Raycast(transform.position, Vector2.up, distance, layerMask))
        //{
        //    weapon.SetActive(true);
        //    if (Time.time > nextLaunchTime)
        //    {
        //        Instantiate(rifle, spawnArrows.position, spawnArrows.rotation);
        //        nextLaunchTime = Time.time + Random.Range(minDelay, maxDelay);
        //    }
        //}
        //else weapon.SetActive(false);
    }
}
