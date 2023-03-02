using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class HandTracking : MonoBehaviour
{
    //表示するオブジェクトを定義
    GameObject[] jointObjects;

    void Start()
    {
        jointObjects = new GameObject[3];

        for (int i = 0; i < jointObjects.Length; i++)
        {
            jointObjects[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            jointObjects[i].transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        }

        jointObjects[0].name = "IndexTip";
        jointObjects[1].name = "IndexDistal";
        jointObjects[2].name = "IndexMiddle";
    }
    
    void Update()
    {
        GetJointPose(TrackedHandJoint.IndexTip,jointObjects[0]);
        GetJointPose(TrackedHandJoint.IndexDistalJoint,jointObjects[1]);
        GetJointPose(TrackedHandJoint.IndexMiddleJoint, jointObjects[2]);
    }

    void GetJointPose(TrackedHandJoint position, GameObject jointObject)
    {
        if (HandJointUtils.TryGetJointPose(position, Handedness.Right, out MixedRealityPose pose))
        {
            jointObject.transform.position = pose.Position; //座標を設定
            jointObject.transform.rotation = pose.Rotation; //回転を設定
        }
    }
}