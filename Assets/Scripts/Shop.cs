using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
	public void PurchaseStandardTurret()
    {
        print("Standard Turret Purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseMissileLauncherTurret()
    {
        print("Missle Launcher Purchased");
        buildManager.SetTurretToBuild(buildManager.missleLauncherPrefab);
    }
}
