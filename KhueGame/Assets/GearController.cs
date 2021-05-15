using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearController : MonoBehaviour
{
    public Image gearHat;
    public Image gearGlasses;
    public Image gearGun;
    public SpriteRenderer playerHat;
    public SpriteRenderer playerGlasses;
    public SpriteRenderer playerGun;

    public void OnGearButtonClick()
    {
        if (gameObject.activeSelf == true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            UpdateGear();
        }
    }

    public void UpdateGear()
    {
        gearGlasses.sprite = playerGlasses.sprite;
        gearHat.sprite = playerHat.sprite;
        gearGun.sprite = playerGun.sprite;
    }
}
