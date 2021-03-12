using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWork : MonoBehaviour
{
    private GameObject rocketBase;
    private ParticleSystem explosion;
    private ParticleSystem trail;
    private Renderer baseRenderer;
    private Renderer coneRenderer;
    private bool flying = true;

    public float rocketSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        rocketBase = GameObject.Find("Base");
        explosion = GetComponent<ParticleSystem>();
        trail = rocketBase.GetComponent<ParticleSystem>();
        baseRenderer = GameObject.Find("Base").GetComponent<Renderer>();
        coneRenderer = GameObject.Find("Cone").GetComponent<Renderer>();

        Fuse();
    }

    // Update is called once per frame
    void Update()
    {
        // Close to the player
        if (transform.position.)

        if (flying) {
            transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime * 15;
        }
    }

    void Fuse()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        // Start the firework
        trail.Play();
        explosion.Play();
        flying = true;

        yield return new WaitForSeconds(3);
        trail.Stop();
        coneRenderer.enabled = false;
        baseRenderer.enabled = false;
        Destroy(this);
    }
}
