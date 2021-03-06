using DG.Tweening;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Transform enemyContainer;

    private void Awake()
    {
        enemyContainer = transform.parent;
    }
    private void Start()
    {
       // transform.DOMove()
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            Destroy(gameObject);

            enemyContainer.GetComponent<SpawnManager>().EnemyDestroyed();
        }
    }


}
