using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Multiplier : MonoBehaviour
{
    [SerializeField] float _multiplier = 2;

    public void multiply(int number)
    {
        print("Si multiplicamos por " + _multiplier + " sale " + _multiplier * number);
    }
    public void multiply2(int number,string msg)
    {
        print(msg + number + " veces, que multiplicado por " + _multiplier + " sale " + _multiplier * number);
    }
}
