using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airExplosionCollision : MonoBehaviour
{
    [SerializeField] private float _timeToExplode = 3f;
    [SerializeField] private float _explosionRadius = 5f;
    [SerializeField] private float _explosionForce = 1000f;
    
    
    // Start is called before the first frame update
    void Start()
    {
     StartCoroutine(InitailizeExplosion());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator InitailizeExplosion() {
        Debug.Log($"start!");
        yield return new WaitForSeconds(_timeToExplode);
        Debug.Log($"after {_timeToExplode} secs");
    //     var surroundingObjects = Physics.OverlapSphere(transform.position, _explosionRadius);
        
    //     foreach (var obj in surroundingObjects)
    //     {
    //         Rigidbody rb = obj.GetComponent<Rigidbody>();
    //         if (rb == null) continue;
            
    //         Debug.Log($"explosion");
    //         rb.AddExplosionForce(_explosionForce,Vector3.up,_explosionRadius);
    //     }
    }
}
