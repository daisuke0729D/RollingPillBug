using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���̃R���|�[�l���g�̓J������ǉ����A
/// �^�[�Q�b�g�Ǝ����̈ʒu�𓯊���������@�\����������
/// </summary>
public class ChaseCamera : MonoBehaviour
{
    public Transform TargetPillBugTransform;

    public Vector3 Target0ffset;
    
    
    // Start is called before the first frame update
     private void Start()
    {

        if (TargetPillBugTransform == null)
        {
            TargetPillBugTransform =
            GameObject.FindObjectOfType<PlayerMoveController>().transform;
        }
    }

    // Update is called once per frame
     private void LateUpdate()
    {
        this.transform.position =
            TargetPillBugTransform.position + Target0ffset;
    }
}
