using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class backToBase : MonoBehaviour
{
    [SerializeField] Transform _base;
    [SerializeField] float _distanceFromBase = 4;
    NavMeshAgent _navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        StartCoroutine(PickFood());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator PickFood()
    {
        while (true)
        {
            Vector3 _randomBaseSpot = new Vector3(_base.position.x + Random.Range(-1*_distanceFromBase, _distanceFromBase),0f, _base.position.z + Random.Range(-1*_distanceFromBase, _distanceFromBase));
            float _randomTimeToMove = Random.Range(6f,25f);
            _navMeshAgent.SetDestination(_randomBaseSpot);
            FaceTarget(_randomBaseSpot);
            yield return new WaitForSeconds(_randomTimeToMove);
        }
        
        
    }

    private void FaceTarget(Vector3 randomBaseSpot)
    {
        Vector3 direction = (randomBaseSpot - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation,Time.deltaTime * 10f);
    }
}

