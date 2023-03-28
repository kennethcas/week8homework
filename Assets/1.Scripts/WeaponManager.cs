using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponManager : MonoBehaviour
{
    [SerializeField]
    private Transform weaponSlot;
    [SerializeField]
    private WeaponDataSO equippedWeapon;
    [SerializeField]
    private AudioSource pickUpSound;

    private GameObject currentWeapon;
    private string weaponString;

    [SerializeField]
    TMP_Text weaponText;

    public void EquipWeapon(WeaponDataSO weaponData)
    {
        pickUpSound.Play(); //plays the audioclip from the weaponDataSO
        equippedWeapon = weaponData;
        if (currentWeapon != null)
        {
            Destroy(currentWeapon);
        }

        currentWeapon = Instantiate(weaponData.weaponPrefab);
        currentWeapon.transform.SetParent(weaponSlot);
        currentWeapon.transform.localPosition = Vector3.zero;
        currentWeapon.transform.localRotation = Quaternion.identity;

        weaponText.text = equippedWeapon.weaponName;
    }
}
