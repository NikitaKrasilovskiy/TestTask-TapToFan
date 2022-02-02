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
        //��� ���, ���������� �� ������� ����� ������� � ��������� �� ��� Z
        Ray ray = new Ray(transform.position, transform.up);
        Physics.Raycast(ray, out hit);

        Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue);
        //���� ��� � ���-�� ��������, ��..
        if (hit.collider != null)
        {
            //���� ��� ����� � ������ � ����� Enemy
            if (hit.collider.CompareTag("Enemy"))
                Debug.Log("������� �� �����!!!");
            //���� ��� ����� ����-�� � ������ ������
            else
                Debug.Log("���� � ����� ����������� ������: " + hit.collider.name);

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
