using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCameraWithDamping: MonoBehaviour
{
    /// <summary>
    /// 追跡するダンゴムシの位置情報
    /// </summary>
    public Transform TargetPillBugTransform;

    /// <summary>
    /// バネ効果の時間
    /// </summary>
    private float smoothTime = 0.3f;

    /// <summary>
    /// ターゲットとの差分の距離
    /// </summary>
    public Vector3 Target0ffset;

    /// <summary>
    /// バネの強さ
    /// </summary>
    private float springStrength = 0.5f;

    /// <summary>
    /// 粘性減衰係数
    /// </summary>
    private float dampingRatio = 0.5f;

    /// <summary>
    /// 現在の速度
    /// </summary>
    private Vector3 velocity = Vector3.zero;

    /// <summary>
    /// Y軸方向の速度
    /// </summary>
    private float yVelocity = 0.0f;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Vector3 desiredPosition = TargetPillBugTransform.position + Target0ffset;

        float deltaY = TargetPillBugTransform.position.y - transform.position.y;

        float springForce = springStrength * deltaY - dampingRatio * yVelocity;

        yVelocity += springForce * Time.fixedDeltaTime;
        
        desiredPosition.y += yVelocity;

        Vector3 smoothedPosition =
            Vector3.SmoothDamp(transform.position,
            desiredPosition, ref velocity, smoothTime);

        smoothedPosition.z = Target0ffset.z;

        transform.position = smoothedPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
