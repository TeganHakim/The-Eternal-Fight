using System.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING };


    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountdown;

    public float searchCountdown = 1f;

    private SpawnState state = SpawnState.COUNTING;

    void Start()
    {
        waveCountdown = timeBetweenWaves;
    }

    void Update()
    {
        if (state == SpawnState.WAITING)
        {
            //check if enemies are still alive
            if (EnemyIsAlive() == false)
            {
                //Begin a new round
                WaveCompleted();
                return;
            }
            else
            {
                return;
            }
        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                //Start Spawning Wave
                StartCoroutine(SpawnWave(waves[nextWave]));
            }            
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    void WaveCompleted()
    {
        Debug.Log("WaveCompleted");

        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("Completed All Waves");
        }

        nextWave++;
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            
            if (GameObject.FindGameObjectWithTag("EnemyRobot") == null)
            {
                Debug.Log("no enemy found");
                return false;
            }
            else
            {
                Debug.Log("enemy alive");
            }
            searchCountdown = 1f;
        }        
        return true;
        
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning Wave");
        state = SpawnState.SPAWNING;

        //Spawn
        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f/_wave.rate);
        }

        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        //Spawn Enemy
        Instantiate(_enemy, transform.position, transform.rotation);
        Debug.Log("Spawning Enemy: " + _enemy.name);
    }
}
