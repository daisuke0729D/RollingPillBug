using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// �Q�[�����ɓo�ꂷ��Item�̃x�[�X�N���X
/// ��b�N���X�Ƃ��Ă΂�܂�
/// </summary>


public class ItemBace : MonoBehaviour
{   /// <summary>
    /// �A�C�e�����擾����Ƃ��̎��s���e��
    /// ItemBase���p�������R���|�[�l���g�Ɉς˂�
    /// </summary>


    protected UnityAction catchItemAction;





    /// <summary>
    /// OnTriggerEnter2D�͐N��������擾���܂�
    /// Rigidbody2D���ǉ����ꂽGameObject�����̃R���|�[�l���g������GameObject��
    /// �N�����Ă����ꍇ�AcacthItemAction�����s����܂�
  �@/// </summary>
    /// <param name="collision"></param>
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (catchItemAction != null) 
        {
            catchItemAction.Invoke();
        }
    }
}


    

