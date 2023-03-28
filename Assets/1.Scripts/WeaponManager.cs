using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class WeaponManager : MonoBehaviour
{
    [SerializeField]
    private Transform weaponSlot;
    [SerializeField]
    private WeaponDataSO equippedWeapon;
    [SerializeField]
    private AudioSource pickUpSound;
    [SerializeField]
    private AudioSource swingWeaponSound;
    [SerializeField]
    private Animator anim;

    public GameObject currentWeapon;
    private string weaponString;

    [SerializeField]
    TMP_Text weaponText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Attack");
            SwingWeapon(equippedWeapon);
        }
    }

    public void EquipWeapon(WeaponDataSO weaponData)
    {
        pickUpSound.Play();
        equippedWeapon = weaponData;
        if (currentWeapon != null) //if there is a weapon currently equipped, destroy the currentweapon
        {
            Destroy(currentWeapon);
        }

        currentWeapon = Instantiate(equippedWeapon.weaponPrefab);
        currentWeapon.transform.SetParent(weaponSlot);
        currentWeapon.transform.localPosition = Vector3.zero;
        currentWeapon.transform.localRotation = Quaternion.identity;

        weaponText.text = equippedWeapon.weaponName;
    }

    private void SwingWeapon(WeaponDataSO weaponData)
    {
        Debug.Log("swingWeapon method called");
        swingWeaponSound.Play();
        anim.SetTrigger("Swing");
    }
}
