using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DollySpeed : MonoBehaviour
{

    CinemachineDollyCart cart;
    // Start is called before the first frame update
    void Start()
    {
        cart = GetComponent<CinemachineDollyCart>();
    }

    public void ChangeSpeed(float spd)
    {
        cart.m_Speed = spd;
    }
}
