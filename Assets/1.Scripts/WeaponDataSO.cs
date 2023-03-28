using UnityEngine;

[CreateAssetMenu(fileName= "_WeaponDataSO", menuName = "ScriptableObject/ WeaponData")]
public class WeaponDataSO : ScriptableObject
{
    public string weaponName;
    public GameObject weaponPrefab;
    //public AudioSource pickUpSound;
}
