using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    AudioSource m_audioSource;

    MeshRenderer m_meshRenderer;

    Collider m_collider;

    [SerializeField]
    AudioClip CoinSound;
    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
        m_collider = GetComponent<Collider>();
        m_meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, 1.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        m_audioSource.PlayOneShot(CoinSound);

        m_meshRenderer.enabled = false;
        m_collider.enabled = false;
    }
}
