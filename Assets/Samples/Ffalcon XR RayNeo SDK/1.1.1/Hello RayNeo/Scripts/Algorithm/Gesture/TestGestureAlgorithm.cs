using RayNeo;
using RayNeo.Native;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestGestureAlgorithm : MonoBehaviour
{
    #region ���ݶ���

    private int Pointer = 0;
    private int Five = 0;
    private int PointerAndStill = 0;

    public Text FiveNum;
    public Text PointerNum;
    public Text CurrentSkeletonContent;
    //��������
    public Text StateCheck;
    //�Ƿ�̬
    public Text DynamicOrStill;
    public Text StillAndPointer;

    public bool IsStill { get; set; }
    #endregion

    #region ��������

    public void Awake()
    {
        GestureManager.Ins.Start();
        GestureManager.Ins.HandStaticStateChange += OnIsStillChanged;
        GestureManager.Ins.GestureTypeCallback += GestureTypeCallback;
    }

    private void Update()
    {
        StateCheck.text = GestureManager.Ins.IsCaptureGesture().ToString();
    }

    private void OnDestroy()
    {
        GestureManager.Ins.HandStaticStateChange -= OnIsStillChanged;
        GestureManager.Ins.GestureTypeCallback -= GestureTypeCallback;
        GestureManager.Ins.Stop();
    }
    #endregion

    #region ����ʶ��
    private void GetCurrentGesture(GestureType GestureType)
    {
        switch (GestureType)
        {
            case GestureType.Five:
                {
                    Five++;
                    FiveNum.text = Five.ToString();
                    break;
                }
            case GestureType.Pointer:
                {
                    Pointer++;
                    PointerNum.text = Pointer.ToString();
                    break;
                }
            case GestureType.Nothing:
            default:
                {
                    break;
                }
        }
    }

    private void OnIsStillChanged(bool isStill)
    {
        IsStill = isStill;
        if (isStill)
        {
            DynamicOrStill.text = "��̬";
        }
        else
        {
            DynamicOrStill.text = "��̬";
        }
    }
    private void GestureTypeCallback(GestureType GestureType)
    {
        GetCurrentGesture(GestureType);
        //Debug.Log("[MercuryX2]��ǰ��������|" + GestureType);
        if (IsStill && GestureType == GestureType.Pointer)
        {
            PointerAndStill++;
            StillAndPointer.text = PointerAndStill.ToString();
        }
    }

    #endregion
}
