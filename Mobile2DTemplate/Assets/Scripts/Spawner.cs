using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] Rock rock;
    [SerializeField] Player player;

    private void Start()
    {
        SpawnRock();
        SpawnPlayer();
    }

    public void SpawnPlayer() => Instantiate(player, transform);

    public void SpawnRock()
    {
        Instantiate(rock, transform);
        StartCoroutine(SpawnTimer());
    }

    IEnumerator SpawnTimer()
    {
        yield return new WaitForSeconds(3f);
        SpawnRock();
    }
}