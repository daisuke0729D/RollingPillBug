using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerRigidbody2DJump : MonoBehaviour
{
    /// <summary>
    /// ジャンプ力の大きさ
    /// </summary>
    public float JumpPower = 5f;

    /// <summary>
    /// 接地しているかのフラグ
    /// </summary>
    private bool isGrounded = false;

    /// <summary>
    /// 地面のレイヤー
    /// </summary>
    public LayerMask GroundLayer;

    /// <summary>
    /// ダンゴムシに設定されているRigiabody2D
    /// </summary>
    private Rigidbody2D pillBugRigidbody2D;

    /// <summary>
    /// 接地判定用の光線の長さ
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
        //もしスペースキーを押し、isGroundのフラグが立っている場合
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            pillBugRigidbody2D.AddForce(Vector2.up * JumpPower,
                ForceMode2D.Impulse);

            isGrounded = false;
        }

    }

    /// <summary>
    /// フレームレートに依存しないUpdateメソッド
    /// 0.02秒に一度実行される
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
    /// Gizmoと呼ばれる補助的なUIを表示するメソッド
    /// </summary>

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position,
            Vector2.down * rayCastDistance,
            Color.red);
    }
}










