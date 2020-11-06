/*Josh Bumbalough
 *Prototype 4
 *Manages spawns of enemies and powerup
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    private float spawnRange = 9;
    public int enemyCount;
    public static int waveNumber = 1;
    public GameObject powerupPrefab;

    // Start is called before the first frame update
    void Start()
    {
        waveNumber = 1;
        SpawnEnemyWave(waveNumber);
        SpawnPowerup(1);
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            SpawnPowerup(1);
        }

        if(waveNumber == 10)
        {
            GameManager.win = true;
        }
    }

     private void SpawnPowerup(int powerupsToSpawn)
    {
        for(int i = 0; i < powerupsToSpawn; i++)
        {
             Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
             Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
