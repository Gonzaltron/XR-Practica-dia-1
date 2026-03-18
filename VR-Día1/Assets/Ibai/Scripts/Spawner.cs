using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject target;
    [SerializeField] float speed;
    [SerializeField] float cooldown;
    [SerializeField] float distance;
    float actualCooldown;
    Vector3 spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnPoint = player.transform.forward * distance;
        actualCooldown += Time.deltaTime;
        if (actualCooldown >= cooldown)
        {
            GameObject cube = Instantiate<GameObject>(target, transform.position, transform.rotation);
            cube.GetComponent<Cube>().player = player;
            cube.GetComponent<Cube>().speed = speed;
            cube.transform.position = spawnPoint;
            cube.transform.position = new Vector3(0, 1.36144f, 0);
            actualCooldown = 0;
        }
    }
}
