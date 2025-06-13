using ColorDash.Managers.PoolManager;
using UnityEngine;

public class Gate_Spawn : MonoBehaviour
{
    [Header("S T R I N G S:")]
    [SerializeField] private string[] gateTags = { "RedGate", "GreenGate", "BlueGate" };

    [Space(5f)]
    [Header("V A L U E S:")]
    [SerializeField] private float spawnInterval;

    [Space(5f)]
    [Header("R E F R E N C E S:")]
    [SerializeField] private Transform SpawnPoint;

    private void Start() => InvokeRepeating(nameof(SpawnGate), 1f, spawnInterval);

    private void SpawnGate()
    {
        int RandomIndex = UnityEngine.Random.Range(0, gateTags.Length);
        string SelectedTag = gateTags[RandomIndex];

        Pool_Manager.instance.SpawnFromPool(SelectedTag, SpawnPoint);
    }
}