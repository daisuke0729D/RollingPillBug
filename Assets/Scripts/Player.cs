using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //�X�N���v�g�̏�����
    //�Ⴆ��playertransform.position�̃h�b�g�́u�́v�ƌ��������邱�Ƃ��ł��܂��B
    //playerTransform��positon�Ƃ����|�󕶂ɂȂ�܂��B
    //������playerTransform�̃Z�~�R�����͋�Ǔ_�ł���u�B�v�ɓ�����܂��B

    /// <summary>
    /// �v���C���[�̈ʒu
    /// </summary>
    public Transform playerTransform;
  

    // Update is called once per frame
    void Update()
    {
        //�������������̓��͂��O����Ȃ������ꍇ
        if (Input.GetAxis("Horizontal") != 0)
        {
            //player��Transform��position�ɐ��������̓��͂̒l�����Z����
            playerTransform.position +=
                   new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        }

    }
}

