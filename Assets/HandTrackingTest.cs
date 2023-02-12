using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

public class HandTrackingTest : MonoBehaviour
{
    //�\������I�u�W�F�N�g���`
    GameObject indexTip;

    void Start()
    {
        indexTip = GameObject.CreatePrimitive(PrimitiveType.Cube);  //�\���p�̗����̂��쐬
        indexTip.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);  //�傫�����w��
    }

    void Update()
    {
        //�E��̐l�����w�̎w��̈ʒu�����擾
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose pose))
        {
            indexTip.transform.position = pose.Position; //���W��ݒ�
            indexTip.transform.rotation = pose.Rotation; //��]��ݒ�
        }
    }
}