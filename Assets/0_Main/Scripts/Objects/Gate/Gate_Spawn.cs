using ColorDash.Managers.PoolManager;
using UnityEngine;

public class Gate_Spawn : MonoBehaviour
{
   [SerializeField]private string[] gateTags = { "RedGate", "GreenGate", "BlueGate" };
   [SerializeField] private float spawnInterval;
    [SerializeField] private Transform SpawnPoint;

    private void Start() =>InvokeRepeating(nameof(SpawnGate), 1f, spawnInterval);

    private void SpawnGate()
    {
        int RandomIndex = UnityEngine.Random.Range(0, gateTags.Length);
        string SelectedTag = gateTags[RandomIndex];

        Pool_Manager.instance.SpawnFromPool(SelectedTag,SpawnPoint);
    }
}
