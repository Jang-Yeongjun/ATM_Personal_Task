using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public delegate void DepositAction();
    public static event DepositAction onDeposit;
    public static event DepositAction onWithdrawal;

    public void OnDeposit()
    {
        Debug.Log("started deposit");
        onDeposit?.Invoke();
    }

    public void OnWithdrawal()
    {
        Debug.Log("started Withdrawal");
        onWithdrawal?.Invoke();
    }
}
