using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject shield;

    private bool TakeShield;
    private int weaponSwitch;

    private void Start()
    {
        TakeShield = true;

        SelectWeapon();
    }

    private void Update()
    {
        int currentWeapon = weaponSwitch;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (weaponSwitch >= transform.childCount - 1)
            {
                weaponSwitch = 0;
            }
            else
            {
                weaponSwitch++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (weaponSwitch <= 0)
            {
                weaponSwitch = transform.childCount - 1;
            }
            else
            {
                weaponSwitch--;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ShieldActive();
        }
        
        if (currentWeapon != weaponSwitch)
        {
            SelectWeapon();
        }
    }

    public void SelectWeapon()
    {
        int i=0;

        foreach (Transform weapon in transform)
        {
            if (i == weaponSwitch)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            
            i++;
        }
    }

    public void ShieldActive()
    {
        if (TakeShield)
        {
            shield.SetActive(false);
            TakeShield = false;
        }
        else
        {
            shield.SetActive(true);
            TakeShield = true;
        }
    }
}
