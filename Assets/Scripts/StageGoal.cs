using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGoal : MonoBehaviour
{
    /// <summary>
    /// �R���|�[�l���g���ǉ����ꂽGameObject��Collider2D��IsTrigger�Ƀ`�F�b�N
    /// �������Ă��蓖�����Ă���GameObject��Rigidbody��Collider2D���������ꍇ�A
    /// ���s�����N������
    /// </summary>
    /// <parem name="collision"></parem>
    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Goal!!");
    }
}
