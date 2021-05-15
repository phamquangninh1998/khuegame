using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crab : MonoBehaviour
{
    public int hp;
    public Image hpbar;
    public GameObject[] item;

    int currentHp;
    // Start is called before the first frame update
    void Start()
    {
        currentHp = hp;
    }

   

    private void OnParticleCollision(GameObject other)
    {
        currentHp--;
        UpdateHpBar();
        if (currentHp < 0)
        {

        Destroy(gameObject);
            DropItem();
        }
    }

    private void DropItem()
    {
        Instantiate(item[UnityEngine.Random.Range(0, item.Length)],transform.position,Quaternion.identity);
    }

    void UpdateHpBar()
    {
        hpbar.fillAmount = ((float)currentHp / hp);
    }
}
