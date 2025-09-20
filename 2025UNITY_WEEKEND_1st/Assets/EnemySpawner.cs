using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform spawnPos;

    [SerializeField] private float spawnInterval = 2.0f;

    private float timeUntilNextSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(enemyPrefab, spawnPos.position, Quaternion.identity);
        timeUntilNextSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {

        timeUntilNextSpawn -= Time.deltaTime;

        if (timeUntilNextSpawn <= 0 )
        {
            // 적을 생성합니다.
            Instantiate(enemyPrefab, spawnPos.position, Quaternion.identity);

            // 다음 생성 시간을 재설정합니다.
            timeUntilNextSpawn = spawnInterval;

        }


    }
}
