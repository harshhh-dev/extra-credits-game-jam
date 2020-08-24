using UnityEngine;

public class BirdSpawning : MonoBehaviour
{
    [SerializeField] GameObject[] birds;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] float startTimeBtwSpawns;
    float timeBtwSpawns;
    int birdsSpawned;

    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            if (birdsSpawned < 120)
            {
                int randBird = Random.Range(0, birds.Length);
                int randSpawnPoint = Random.Range(0, spawnPoints.Length);

                Instantiate(birds[randBird], spawnPoints[randSpawnPoint].position, Quaternion.identity);

                timeBtwSpawns = startTimeBtwSpawns;

                birdsSpawned++;
            }
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
