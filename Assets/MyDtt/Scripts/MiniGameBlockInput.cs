using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameBlockInput : MonoBehaviour
{
    public bool IsInputBlocked
    {
        get
        {
            return isInputBlocked;
        }
        set 
        {
            isInputBlocked = value;
            inputBlockGO.SetActive(isInputBlocked);
        }
    }

    private bool isInputBlocked;

    [SerializeField] private GameObject inputBlockGO;
}
