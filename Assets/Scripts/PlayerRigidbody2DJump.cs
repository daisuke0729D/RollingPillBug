using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerRigidbody2DJump : MonoBehaviour
{
    /// <summary>
    /// �W�����v�͂̑傫��
    /// </summary>
    public float JumpPower = 5f;

    /// <summary>
    /// �ڒn���Ă��邩�̃t���O
    /// </summary>
    private bool isGrounded = false;

    /// <summary>
    /// �n�ʂ̃��C���[
    /// </summary>
    public LayerMask GroundLayer;

    /// <summary>
    /// �_���S���V�ɐݒ肳��Ă���Rigiabody2D
    /// </summary>
    private Rigidbody2D pillBugRigidbody2D;

    /// <summary>
    /// �ڒn����p�̌����̒���
    /// </summary>
    private float rayCastDistance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        pillBugRigidbody2D = GetComponent < Rigidbody2D > ();
    }

    // Update is called once per frame
    void Update()
    {
        //�����X�y�[�X�L�[�������AisGround�̃t���O�������Ă���ꍇ
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            pillBugRigidbody2D.AddForce(Vector2.up * JumpPower,
                ForceMode2D.Impulse);

            isGrounded = false;
        }

    }

    /// <summary>
    /// �t���[�����[�g�Ɉˑ����Ȃ�Update���\�b�h
    /// 0.02�b�Ɉ�x���s�����
    /// </summary>



    private void FixedUpdate()
    {
        isGrounded = Physics2D.Raycast(
            transform.position,
            Vector2.down,
            rayCastDistance,
            GroundLayer);
    }
    
    /// <summary>
    /// Gizmo�ƌĂ΂��⏕�I��UI��\�����郁�\�b�h
    /// </summary>

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position,
            Vector2.down * rayCastDistance,
            Color.red);
    }
}










