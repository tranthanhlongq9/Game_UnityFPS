using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject explosionPrefab;

    public float blastRadius = 5f;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);

        GameObject explosionEffect = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosionEffect, 5f);

        HitTargets();

        Destroy(gameObject);
    }

    void HitTargets()
    {
        Collider selfCollider = GetComponent<Collider>();
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, blastRadius);

        foreach(Collider hitCollider in hitColliders)
        {
            if (hitCollider == selfCollider) continue;

            if(hitCollider is CharacterController)
            {
                print("Player is in blast radius");
                RaycastHit hit;

                Vector3 directionToTarget = hitCollider.transform.position - transform.position;

                Debug.DrawRay(transform.position, directionToTarget.normalized * 10, Color.red, 10);

                if(Physics.Raycast(transform.position, directionToTarget, out hit))
                {
                    if (hitCollider is CharacterController)
                    {
                        print("Grenade see player");
                        
                    }
                    else
                    {
                        print("Grenade can't see player");
                    }
                }
                else
                {
                    print("Ray hit nothing");
                }
                
            }
            
        }
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, blastRadius);
    }
}
