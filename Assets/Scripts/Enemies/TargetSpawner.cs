using UnityEngine;

/// <summary>
/// Class that controls the target spawner
/// </summary>
public class TargetSpawner : MonoBehaviour
{
    /// <summary>
    /// Max ammount of object to spawn
    /// </summary>
    public int spawnLimit;

    /// <summary>
    /// Timer before each spawn
    /// </summary>
    public float spawnTimer;

    /// <summary>
    /// The object to spawn
    /// </summary>
    public TargetDummy targetDummy;

    /// <summary>
    /// Actual counter of objects spawned
    /// </summary>
    private int dummyCounter;

    /// <summary>
    /// Actual timer before each spawn
    /// </summary>
    private float actualSpawnTimer;

    private void Start()
    {
        actualSpawnTimer = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTargetDummy();
    }

    /// <summary>
    /// Spawn a new object, if the spawn limit has not been reached and after the spawn timer depleted
    /// </summary>
    private void SpawnTargetDummy()
    {
        if(dummyCounter < spawnLimit)
        {
            actualSpawnTimer -= Time.deltaTime;
            if (actualSpawnTimer < 0f)
            {
                TargetDummy targetDummy = Instantiate(this.targetDummy, transform.position, Quaternion.identity);
                // Guarante the object spawned has a reference to this
                targetDummy.SetSpawner(this);
                actualSpawnTimer = spawnTimer;
                dummyCounter++;
            }
        }
    }

    /// <summary>
    /// One object has been destroyed, so this class will subtract from its counter
    /// </summary>
    public void DummyDestroyed()
    {
        dummyCounter--;
    }
}
