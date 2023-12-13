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
        onDeposit?.Invoke();
    }

    public void OnWithdrawal()
    {
        onWithdrawal?.Invoke();
    }
}
