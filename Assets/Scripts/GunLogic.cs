using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunLogic : MonoBehaviour
{
    [SerializeField]
    GameObject m_bulletPrefab;

    [SerializeField]
    Transform m_bulletSpawnPoint;

    float maxBullets = 20;
    float currentBullets = 20;

    [SerializeField]
    Text m_AmmoCount;

    // Start is called before the first frame update
    void Start()
    {
        SetAmmoText();
    }

    void SetAmmoText()
    {
        m_AmmoCount.text = "Ammo: " + currentBullets;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && currentBullets > 0)
        {
            Instantiate(m_bulletPrefab, m_bulletSpawnPoint.position, m_bulletSpawnPoint.rotation * m_bulletPrefab.transform.rotation);

            --currentBullets;
            SetAmmoText();
        }
    }
}
