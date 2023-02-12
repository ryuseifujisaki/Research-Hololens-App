using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

public class HandTrackingTest : MonoBehaviour
{
    //表示するオブジェクトを定義
    GameObject indexTip;

    void Start()
    {
        indexTip = GameObject.CreatePrimitive(PrimitiveType.Cube);  //表示用の立方体を作成
        indexTip.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);  //大きさを指定
    }

    void Update()
    {
        //右手の人差し指の指先の位置情報を取得
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose pose))
        {
            indexTip.transform.position = pose.Position; //座標を設定
            indexTip.transform.rotation = pose.Rotation; //回転を設定
        }
    }
}