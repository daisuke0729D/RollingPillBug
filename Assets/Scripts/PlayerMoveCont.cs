// using�͎����ɕK�v�ȃ��C�u�������Ăяo���Ă����̂Ɏg�p���܂��B
// �Ⴆ��using UnityEnging���폜����ƁA
// MonoBehaviour(�P�Ƃłӂ�܂����Ƃ��ł���悤�ɂȂ�݌v�})
// ���g���Ȃ��Ȃ邽�߁AStart���\�b�h�Ȃǂ����p�ł��Ȃ��Ȃ�܂��B
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class�Ƃ͎����������@�\�̐݌v�}�ł��B
// Unity�ɂ����ăQ�[�������ꍇ�́A���̐݌v�}���R���|�[�l���g
// �Ƃ���GameObject�ɒǉ����Ă����A�@�\���������Ă����܂��B
public class PlayerMoveController : MonoBehaviour
{
    // class�̒�����{}�̒��ɓ�������A�܂������ׂ��͕ϐ��ł��B
    // �ϐ��Ƃ́A���̐݌v�}�̒��Ŏg�������l�X�ȗv�f��
    // ��`���邱�Ƃ��ł���v�f�ł��B
    // �Ⴆ�Γ����Ƃ�������ɕK�v��Spead�Ȃǂ̐��l�A
    // �����̕\���ȂǂɎg�p���镶����ȂǁA
    // ���L�ŏЉ�郁�\�b�h����Ő錾���Ă����܂��B
    // �ϐ��̐錾�⏈���̍Ō�ɂ���[;]��
    // ���{��Ō����Ƃ����[�B]�ł�
    //�X�N���v�g�̏�����
    //�Ⴆ��playertransform.position�̃h�b�g�́u�́v�ƌ��������邱�Ƃ��ł��܂��B
    //playerTransform��positon�Ƃ����|�󕶂ɂȂ�܂��B
    //������playerTransform�̃Z�~�R�����͋�Ǔ_�ł���u�B�v�ɓ�����܂��B
    // ��{�I�ɕϐ���錾����Ƃ��́uprivate�v
    private string helloWorld = "Hello World";
    // ����class�̖ړI�̓v���C���[�𓮂������ƂȂ̂�
    // �ړ��X�s�[�h���ςł���悤�ɕϐ����쐬���܂��B
    // �ϐ����������A���̕ϐ��̈��̍s��///�Ƒł�
    // �T�}���[�i�T�v�j���L�q���邱�Ƃ��ł��܂��B
    /// <summary>
    /// �ړ��X�s�[�h
    /// </summary>
    public Transform playerTransform;
    public float MoveSpeed = 1.0f;

    /// <summary>
    /// �X�s�[�h���v�Z���Ă���郁�\�b�h
    /// </summary>
    /// <returns></returns>
    public float CulcSpeed()
    {
        return MoveSpeed * Time.deltaTime;
    }

    public bool CanMove = true;


    /// <summary>
    /// void�^�͉����Ԃ��Ȃ��Ă����������������Ɏg�p���܂�
    /// �����Debug.Log��"HelloWorld!"�Əo�͂���
    /// </summary>
    public void HelloWorld()
    {
        Debug.Log(helloWorld);
    }
    // ����class(�R���|�[�l���g)���ǉ����ꂽ
    // GameObject��Hierarchy���ŃA�N�e�B�u�ɂȂ��Ă���ꍇ�A
    // ��x�������s����郁�\�b�h(����)�ł��B
    
    // Update is called once per frame
    // ����class(�R���|�[�l���g)���ǉ����ꂽGameObject��
    // Hierarchy���ŃA�N�e�B�u�ɂȂ��Ă���ꍇ�A
    // ���t���[�����s����郁�\�b�h�i�����j�ł��B
    // ���t���[���Ȃ̂ŁAPC�N��CUP�̏������x�ɂ����
    // ���s�񐔂��ς���Ă��܂��B
    void Update()
    {
        HelloWorld();
        // �������ւ̎����ړ����������Ă����܂��B
        // Time.deltaTime�͑O�̃t���[�����I�����Ă���
        // ���݂̃t���[�����J�n����܂ł̎��Ԃł��B
        // ���ۂɂ�0.016�b�Ȃǂ̒l������܂��B
        // ���̒l���|���Z���邱�ƂŁA�e���s����1�b��
        // ���������ʉ��ł��܂��B 
        // �����̈ʒu���ɑ΂��āA
        // x���ɉ��Z����������������s���Ă����܂��B
        if (CanMove)
        {
            transform.position +=
                new Vector3(CulcSpeed(), 0, 0);
        }

    }
}

