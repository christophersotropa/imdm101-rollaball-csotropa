using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject PickUp;
    public int count = 12;

    public Vector3 minBounds = new Vector3(-25f, 0.588f, 25f);
    public Vector3 maxBounds = new Vector3(25f, 0.588f, -25f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCubes();
    }

    // Update is called once per frame
    void SpawnCubes()
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(minBounds.x, maxBounds.x),
                0.588f,
                Random.Range(minBounds.z, maxBounds.z)
            );

            Instantiate(PickUp, randomPosition, Quaternion.identity);
        }
    }
}
