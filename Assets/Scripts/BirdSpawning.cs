using UnityEngine;

public class BirdSpawning : MonoBehaviour
{
    [SerializeField] GameObject[] birds;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] float startTimeBtwSpawns;
    float timeBtwSpawns;

    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            int randBird = Random.Range(0, birds.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(birds[randBird], spawnPoints[randSpawnPoint].position, Quaternion.identity);

            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }

        if (startTimeBtwSpawns > 0.2f)
        {
            startTimeBtwSpawns -= 0.01f * Time.deltaTime;
        }
    }
}
