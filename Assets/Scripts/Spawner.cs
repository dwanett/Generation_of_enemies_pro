using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemie _prefabEnemie;
    [SerializeField] private float _delaySpawn;
    [SerializeField] private TargetMove _targetEnemie;

    public void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_delaySpawn);
            Enemie enemie = Instantiate(_prefabEnemie, transform.position, Quaternion.identity);
            enemie.SetTargetMove(_targetEnemie);
        }
    }
}
