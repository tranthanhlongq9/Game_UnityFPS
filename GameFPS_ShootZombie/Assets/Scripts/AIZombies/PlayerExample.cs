using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerExample : MonoBehaviour
{
    //public AudioClip shootSound;
    public float soundIntensity = 5f;
    public float walkEnemyPerceptionRadius = 1f;
    public float sprintEnemyPerceptionRadius = 2f;
    public LayerMask zombieLayer;

    public int attackDamage = 30;
    public Transform spherecastSpawn;


    private AudioSource audioSource;
    private FirstPersonController fpsc;
    private SphereCollider sphereCollider;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        fpsc = GetComponent<FirstPersonController>();
        sphereCollider = GetComponent<SphereCollider>();
    }

    void Update()
    {
        //bấm chuột trái thì sẽ gọi đến fire()
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
        if (fpsc.GetPlayerStealthProfile() == 0) // nếu player trả về 0 (đi bộ)xem code bên FirstPersonController.cs 332
        {
            //thay đổi bán kính
            sphereCollider.radius = walkEnemyPerceptionRadius;
        }
        else
        // ngược lại player trả về 1(chạy)
        {
            //thay đổi bán kính
            sphereCollider.radius = sprintEnemyPerceptionRadius;
        }
    }

    //xử lý bắn
    public void Fire()
    {
        //audioSource.PlayOneShot(shootSound);
        
        
        Collider[] zombies = Physics.OverlapSphere(transform.position, soundIntensity, zombieLayer);
        for(int i = 0; i < zombies.Length; i++)
        {
            zombies[i].GetComponent<AIExample>().OnAware();
        }

        RaycastHit hit;
        if (Physics.SphereCast(spherecastSpawn.position, 0.5f, spherecastSpawn.TransformDirection(Vector3.forward), out hit, zombieLayer))
        {
            hit.transform.GetComponent<AIExample>().OnHit(attackDamage);
        }


    }

    //xử lý va chạm Trigger kích hoạt
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<AIExample>().OnAware();
        }
    }

}
