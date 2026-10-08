using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject coin;
    public GameObject goodercoin;
    public GameObject heals;
    public GameObject ouch;
    private float timer = 0f;
    private float timeAcceleration = 1f;

    
    void Start()
    {
        SpawnObjects();
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime * timeAcceleration;
        timeAcceleration += 0.0025f;

        if (timer >= 7.5)
        {
            SpawnObjects();
            timer = 0;
        }
    }

    public void SpawnObjects()
    {
        int SpawnPointX = Random.Range(-7, 7);
        int ChooseType = Random.Range(0, 7);

        Vector3 spawnPosition = new Vector3(SpawnPointX, 10, -4);

        if (ChooseType == 0 || ChooseType == 4)
        {
            Instantiate(coin, spawnPosition, Quaternion.identity);
        }
        if (ChooseType == 1 || ChooseType == 5)
        {
            Instantiate(goodercoin, spawnPosition, Quaternion.identity);
        }
        if (ChooseType == 2 || ChooseType == 6)
        {
            Instantiate(heals, spawnPosition, Quaternion.identity);
        }
        if (ChooseType == 3 || ChooseType == 7)
        {
            Instantiate(ouch, spawnPosition, Quaternion.identity);
        }

        Debug.Log("Spawned object #" + ChooseType);
    }

}
