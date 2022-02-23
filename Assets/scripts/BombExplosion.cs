using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Explosion());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
