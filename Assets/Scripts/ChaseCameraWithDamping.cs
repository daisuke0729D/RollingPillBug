using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCameraWithDamping: MonoBehaviour
{
    /// <summary>
    /// �ǐՂ���_���S���V�̈ʒu���
    /// </summary>
    public Transform TargetPillBugTransform;

    /// <summary>
    /// �o�l���ʂ̎���
    /// </summary>
    private float smoothTime = 0.3f;

    /// <summary>
    /// �^�[�Q�b�g�Ƃ̍����̋���
    /// </summary>
    public Vector3 Target0ffset;

    /// <summary>
    /// �o�l�̋���
    /// </summary>
    private float springStrength = 0.5f;

    /// <summary>
    /// �S�������W��
    /// </summary>
    private float dampingRatio = 0.5f;

    /// <summary>
    /// ���݂̑��x
    /// </summary>
    private Vector3 velocity = Vector3.zero;

    /// <summary>
    /// Y�������̑��x
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
