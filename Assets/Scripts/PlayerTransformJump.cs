using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransformJump : MonoBehaviour
{
    // 変数を宣言するときのTips
    // privateで宣言する場合は変数名の頭文字を小文字にします
    // publicで宣言するときは変数名の頭文字を大文字にします
    // 実際にはゲーム会社によって、このあたりの名前付けのルールは変わります
    // プロジェクトが発足するとコーディング規約というものを最初に定めることが多いです
    // これはC#に限った話ではなく、C++にもありますし、Javaなどにもあります
    // 例えばVisualStudioではCtrl+Kキー+Dキーでフォーマットしてくれます
    /// <summary>
    /// ジャンプ開始時の力となります
    /// </summary>
    private float initialJumpForce = 5f;

    /// <summary>
    ///  実際の重力の値(9.81)ではないのですが、ジャンプ中に上からかかる力を1と定義します
    /// </summary>
    private float gravity = 1f;

    /// <summary>
    /// 垂直方向の速度を指定します
    /// </summary>
    private float verticalVelocity;

    /// <summary>
    /// 接地しているかのフラグです
    /// boolはtrueかfalseという二値を判定したいときの変数となります
    /// </summary>
    private bool isGrounded = false;

    /// <summary>
    /// ジャンプの総時間
    /// </summary>
    private float jumpTime = 1f;

    /// <summary>
    /// ジャンプの経過時間
    /// </summary>
    private float jumpElapsedTime = 0f;


    // フレームレートに則って、Game開始時に1回だけ実行される
    // Start is called before the first frame update
    void Start()
    {
        // 垂直方向の加速度を0にします
        verticalVelocity = 0f;
        // 初期状態は地面に接地しているのでフラグをたてます
        isGrounded = true;
        // ジャンプの経過時間を0にします
        jumpElapsedTime = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        // if文は"もしくは(条件)だったら{処理}を実行する"と読むことができます

        // "もし(スペースキーが押され、かつ地面に接地しているときのフラグがtrueの場合)に
        // {垂直方向にジャンプ力を設定し、地面に接地しているときのフラグをfalseにする}"
        // という日本語に読み替えることができます
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // ジャンプするときので垂直方向の加速度をinitiaJumpForceの値(5)を代入します
            verticalVelocity = initialJumpForce;
            // 地面に接地しているときのフラグをfalseにします
            isGrounded = false;

            // ジャンプの時間をリセット
            jumpElapsedTime = 0f;


        }
        // "もし(接地していない)場合、{位置の更新と接地しているかの判定の処理}を行う"
        if (!isGrounded)
        {
            // ジャンプ中の経過時間を更新
            jumpElapsedTime += Time.deltaTime;


            // 1フレームごとに垂直方向の加速度から重力を減算していく
            // この式は、重力が経過時間に比例して速度に与える影響を計算します
            // 初期速度から始まり、時間と共に重力の影響で速度が減少し、
            // 最終的には下降に転じます
            verticalVelocity -= gravity * jumpElapsedTime;

            // 位置の更新は、速度に時間を掛けたものとして計算されます
            transform.position += new Vector3(0, verticalVelocity * Time.deltaTime,0);　　　　　　　　　　　　
            
            
            
            verticalVelocity -= gravity;

            //位置の更新
            transform.position += new Vector3(0, verticalVelocity, 0);

            //地面に接地したかを確認
            if (transform.position.y <= -0.65f)
            {
                //位置の更新
                transform.position =
                    new Vector3(transform.position.x, -0.65f, transform.position.z);
                //接地しているので垂直方向の加速度は0になります
                verticalVelocity = 0;
                //地面に接地しているときのフラグをtrueにします
                isGrounded = true;
            }

            // ジャンプの総秒数以上にジャンプの経過時間が加算された場合
            if (jumpElapsedTime >= jumpTime)
            {
                //垂直方向の加速度を0にして、即座に下降に転じてもらう
                verticalVelocity = 0;　　　　　　　　　　　　　　　　
            }


        }


    }



}
