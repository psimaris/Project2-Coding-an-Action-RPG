using UnityEngine;
using CreatorKitCode;

public class SpawnerEnemy : MonoBehaviour
{

    public GameObject ObjectToSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
        EnemyAngle myEnemyAngle = new EnemyAngle(15);

        SpawnEnemy(myEnemyAngle.NextAngle());
        SpawnEnemy(myEnemyAngle.NextAngle());
        
    }

    void SpawnEnemy(int angle) {
            int radius = 5;

            Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
            Vector3 spawnEnemy = transform.position + direction * radius;
            Instantiate(ObjectToSpawn, spawnEnemy, Quaternion.identity);
        }
}

public class EnemyAngle {
    int angle;
    int step;

    public EnemyAngle(int increment) {
        step = increment;
        angle = 0;
    }
    public int NextAngle() {
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);

        return currentAngle;
    }
}
