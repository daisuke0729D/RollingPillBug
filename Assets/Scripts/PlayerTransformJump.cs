using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransformJump : MonoBehaviour
{
    // �ϐ���錾����Ƃ���Tips
    // private�Ő錾����ꍇ�͕ϐ����̓��������������ɂ��܂�
    // public�Ő錾����Ƃ��͕ϐ����̓�������啶���ɂ��܂�
    // ���ۂɂ̓Q�[����Ђɂ���āA���̂�����̖��O�t���̃��[���͕ς��܂�
    // �v���W�F�N�g����������ƃR�[�f�B���O�K��Ƃ������̂��ŏ��ɒ�߂邱�Ƃ������ł�
    // �����C#�Ɍ������b�ł͂Ȃ��AC++�ɂ�����܂����AJava�Ȃǂɂ�����܂�
    // �Ⴆ��VisualStudio�ł�Ctrl+K�L�[+D�L�[�Ńt�H�[�}�b�g���Ă���܂�
    /// <summary>
    /// �W�����v�J�n���̗͂ƂȂ�܂�
    /// </summary>
    private float initialJumpForce = 5f;

    /// <summary>
    ///  ���ۂ̏d�͂̒l(9.81)�ł͂Ȃ��̂ł����A�W�����v���ɏォ�炩����͂�1�ƒ�`���܂�
    /// </summary>
    private float gravity = 1f;

    /// <summary>
    /// ���������̑��x���w�肵�܂�
    /// </summary>
    private float verticalVelocity;

    /// <summary>
    /// �ڒn���Ă��邩�̃t���O�ł�
    /// bool��true��false�Ƃ�����l�𔻒肵�����Ƃ��̕ϐ��ƂȂ�܂�
    /// </summary>
    private bool isGrounded = false;

    /// <summary>
    /// �W�����v�̑�����
    /// </summary>
    private float jumpTime = 1f;

    /// <summary>
    /// �W�����v�̌o�ߎ���
    /// </summary>
    private float jumpElapsedTime = 0f;


    // �t���[�����[�g�ɑ����āAGame�J�n����1�񂾂����s�����
    // Start is called before the first frame update
    void Start()
    {
        // ���������̉����x��0�ɂ��܂�
        verticalVelocity = 0f;
        // ������Ԃ͒n�ʂɐڒn���Ă���̂Ńt���O�����Ă܂�
        isGrounded = true;
        // �W�����v�̌o�ߎ��Ԃ�0�ɂ��܂�
        jumpElapsedTime = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        // if����"��������(����)��������{����}�����s����"�Ɠǂނ��Ƃ��ł��܂�

        // "����(�X�y�[�X�L�[��������A���n�ʂɐڒn���Ă���Ƃ��̃t���O��true�̏ꍇ)��
        // {���������ɃW�����v�͂�ݒ肵�A�n�ʂɐڒn���Ă���Ƃ��̃t���O��false�ɂ���}"
        // �Ƃ������{��ɓǂݑւ��邱�Ƃ��ł��܂�
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // �W�����v����Ƃ��̂Ő��������̉����x��initiaJumpForce�̒l(5)�������܂�
            verticalVelocity = initialJumpForce;
            // �n�ʂɐڒn���Ă���Ƃ��̃t���O��false�ɂ��܂�
            isGrounded = false;

            // �W�����v�̎��Ԃ����Z�b�g
            jumpElapsedTime = 0f;


        }
        // "����(�ڒn���Ă��Ȃ�)�ꍇ�A{�ʒu�̍X�V�Ɛڒn���Ă��邩�̔���̏���}���s��"
        if (!isGrounded)
        {
            // �W�����v���̌o�ߎ��Ԃ��X�V
            jumpElapsedTime += Time.deltaTime;


            // 1�t���[�����Ƃɐ��������̉����x����d�͂����Z���Ă���
            // ���̎��́A�d�͂��o�ߎ��Ԃɔ�Ⴕ�đ��x�ɗ^����e�����v�Z���܂�
            // �������x����n�܂�A���ԂƋ��ɏd�͂̉e���ő��x���������A
            // �ŏI�I�ɂ͉��~�ɓ]���܂�
            verticalVelocity -= gravity * jumpElapsedTime;

            // �ʒu�̍X�V�́A���x�Ɏ��Ԃ��|�������̂Ƃ��Čv�Z����܂�
            transform.position += new Vector3(0, verticalVelocity * Time.deltaTime,0);�@�@�@�@�@�@�@�@�@�@�@�@
            
            
            
            verticalVelocity -= gravity;

            //�ʒu�̍X�V
            transform.position += new Vector3(0, verticalVelocity, 0);

            //�n�ʂɐڒn���������m�F
            if (transform.position.y <= -0.65f)
            {
                //�ʒu�̍X�V
                transform.position =
                    new Vector3(transform.position.x, -0.65f, transform.position.z);
                //�ڒn���Ă���̂Ő��������̉����x��0�ɂȂ�܂�
                verticalVelocity = 0;
                //�n�ʂɐڒn���Ă���Ƃ��̃t���O��true�ɂ��܂�
                isGrounded = true;
            }

            // �W�����v�̑��b���ȏ�ɃW�����v�̌o�ߎ��Ԃ����Z���ꂽ�ꍇ
            if (jumpElapsedTime >= jumpTime)
            {
                //���������̉����x��0�ɂ��āA�����ɉ��~�ɓ]���Ă��炤
                verticalVelocity = 0;�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@
            }


        }


    }



}
