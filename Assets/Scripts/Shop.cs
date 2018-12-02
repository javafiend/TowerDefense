using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint standardTurret;
    public TurretBlueprint missleLauncher;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
	public void SelectStandardTurret()
    {
        print("Standard Turret Purchased");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncherTurret()
    {
        print("Missle Launcher Purchased");
        buildManager.SelectTurretToBuild(missleLauncher);
    }
}
