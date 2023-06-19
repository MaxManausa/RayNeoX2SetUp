using RayNeo.Tool;
using UnityEngine;
using UnityEngine.UI;
public class TestInput : MonoBehaviour
{
    [SerializeField]
    private Text InputTxt;

    private void OnEnable()
    {
        TouchEventCtrl.Instance.OnTouchStart += OnTouchStart;
        TouchEventCtrl.Instance.OnTouchDown  += OnTouchDown;
        TouchEventCtrl.Instance.OnTouchUp    += OnTouchUp;

        TouchEventCtrl.Instance.OnSwipeLeftEnd  += OnSwipeLeftEnd;
        TouchEventCtrl.Instance.OnSwipeRightEnd += OnSwipeRightEnd;

        TouchEventCtrl.Instance.OnSwipeLeft  += OnSwipeLeft;
        TouchEventCtrl.Instance.OnSwipeRight += OnSwipeRight;

        TouchEventCtrl.Instance.OnSimpleTap += OnSimpleTap;
        TouchEventCtrl.Instance.OnDoubleTap += OnDoubleTap;
        TouchEventCtrl.Instance.OnTripleTap += OnTripleTap;

        TouchEventCtrl.Instance.OnLongTap += OnLongTap;
    }

    private void OnDisable()
    {
        TouchEventCtrl.Instance.OnTouchStart -= OnTouchStart;
        TouchEventCtrl.Instance.OnTouchDown  -= OnTouchDown;
        TouchEventCtrl.Instance.OnTouchUp    -= OnTouchUp;

        TouchEventCtrl.Instance.OnSwipeLeftEnd  -= OnSwipeLeftEnd;
        TouchEventCtrl.Instance.OnSwipeRightEnd -= OnSwipeRightEnd;

        TouchEventCtrl.Instance.OnSwipeLeft  -= OnSwipeLeft;
        TouchEventCtrl.Instance.OnSwipeRight -= OnSwipeRight;


        TouchEventCtrl.Instance.OnDoubleTap -= OnDoubleTap;
        TouchEventCtrl.Instance.OnSimpleTap -= OnSimpleTap;
        TouchEventCtrl.Instance.OnTripleTap -= OnTripleTap;

        TouchEventCtrl.Instance.OnLongTap   -= OnLongTap;
    }


    private void OnTouchStart()
    {
        Debug.Log("[MercuryX2]:OnTouchStart");
        InputTxt.text = "OnTouchStart";
    }

    private void OnTouchDown()
    {
        Debug.Log("[MercuryX2]:OnTouchDown");
        InputTxt.text = "OnTouchDown";
    }

    private void OnTouchUp()
    {
        Debug.Log("[MercuryX2]:OnTouchUp");
        InputTxt.text = "OnTouchUp";
    }

    private void OnSwipeLeftEnd()
    {
        Debug.Log("[MercuryX2]:OnSwipeLeftEnd");
        InputTxt.text = "OnSwipeLeftEnd";
    }

    private void OnSwipeRightEnd()
    {
        Debug.Log("[MercuryX2]:OnSwipeRightEnd");
        InputTxt.text = "OnSwipeRightEnd";
    }

    private void OnSwipeLeft()
    {
        Debug.Log("[MercuryX2]:OnSwipeLeft");
        InputTxt.text = "OnSwipeLeft";
    }

    private void OnSwipeRight()
    {
        Debug.Log("[MercuryX2]:OnSwipeRight");
        InputTxt.text = "OnSwipeRight";
    }

    private void OnDoubleTap()
    {
        Debug.LogError("[MercuryX2]:OnDoubleTap");
        InputTxt.text = "OnDoubleTap";
    }

    private void OnSimpleTap()
    {
        Debug.LogError("[MercuryX2]:OnSimpleTap");
        InputTxt.text = "OnSimpleTap";
    }
    private void OnTripleTap()
    {
        Debug.LogError("[MercuryX2]:OnTripleTap");
        InputTxt.text = "OnTripleTap";
    }

    private void OnLongTap()
    {
        Debug.LogError("[MercuryX2]:OnLongTap");
        InputTxt.text = "OnLongTap";
    }
}
