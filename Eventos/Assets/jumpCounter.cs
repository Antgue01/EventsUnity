using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class jumpCounter : MonoBehaviour
{
    int jumps = 0;
    [SerializeField] UnityEvent<int> onCount;
    [SerializeField] UnityEvent<int, string> onCount2;
    private void Awake()
    {
        Controller.onJump += CountJumps;
    }
    void CountJumps()
    {
        jumps++;
        print(jumps);
        onCount?.Invoke(jumps);
        onCount2?.Invoke(jumps, "He saltado ");
    }
}
