using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Debug = UnityEngine.Debug;

public class EyeTracking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //目線を常に表示
        PointerUtils.SetGazePointerBehavior(PointerBehavior.AlwaysOn);
}

    // Update is called once per frame
    void Update()
    {
        //オブジェクトを視線の位置に配置
        var defaultDistanceInMeters = 6f;
        var eyeGazeProvider = CoreServices.InputSystem?.EyeGazeProvider;
        gameObject.transform.position = eyeGazeProvider.GazeOrigin + eyeGazeProvider.GazeDirection.normalized * defaultDistanceInMeters;
    }

}
