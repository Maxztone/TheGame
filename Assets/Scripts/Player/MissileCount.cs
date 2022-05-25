using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileCount : MonoBehaviour
{
    public PlayerScript playerScript;
    Text missiles;

    private void Start()
    {
        missiles = GetComponent<Text>();
    }

    private void Update()
    {
        missiles.text = "Missiles: " + playerScript.missilesQuantity;
    }
}
