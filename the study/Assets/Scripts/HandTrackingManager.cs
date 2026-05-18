using UnityEngine;

public class HandTrackingManager : MonoBehaviour
{
    [SerializeField] private OVRHand leftHand;
    [SerializeField] private OVRHand rightHand;

    void Update()
    {
        if (leftHand != null && leftHand.IsTracked)
        {
            TrackHand(leftHand, "Left");
        }

        if (rightHand != null && rightHand.IsTracked)
        {
            TrackHand(rightHand, "Right");
        }
    }

    void TrackHand(OVRHand hand, string handName)
    {
        // 人差し指の先端座標を取得
        Vector3 indexTipPos = hand.PointerPose.position;
        Debug.Log($"{handName} 指先位置: {indexTipPos}");

        // ピンチジェスチャーの検出
        if (hand.GetFingerIsPinching(OVRHand.HandFinger.Index))
        {
            Debug.Log($"{handName} ピンチ検出！");
        }
    }
}