// usingは実数に必要なライブラリを呼び出しておくのに使用します。
// 例えばusing UnityEngingを削除すると、
// MonoBehaviour(単独でふるまうことができるようになる設計図)
// が使えなくなるため、Startメソッドなどが利用できなくなります。
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// classとは実装したい機能の設計図です。
// Unityにおいてゲームを作る場合は、この設計図をコンポーネント
// としてGameObjectに追加していき、機能を実装していきます。
public class PlayerMoveController : MonoBehaviour
{
    // classの中括弧{}の中に入ったら、まず書くべきは変数です。
    // 変数とは、この設計図の中で使いたい様々な要素を
    // 定義することができる要素です。
    // 例えば動くという動作に必要なSpeadなどの数値、
    // 文字の表示などに使用する文字列など、
    // 下記で紹介するメソッドより上で宣言しておきます。
    // 変数の宣言や処理の最後につける[;]は
    // 日本語で言うところの[。]です
    //スクリプトの書き方
    //例えばplayertransform.positionのドットは「の」と言い換えることができます。
    //playerTransformのpositonという翻訳文になります。
    //そしてplayerTransformのセミコロンは句読点である「。」に当たります。
    // 基本的に変数を宣言するときは「private」
    private string helloWorld = "Hello World";
    // このclassの目的はプレイヤーを動かすことなので
    // 移動スピードを可変できるように変数を作成します。
    // 変数を作った後、その変数の一つ上の行で///と打つと
    // サマリー（概要）を記述することができます。
    /// <summary>
    /// 移動スピード
    /// </summary>
    public Transform playerTransform;
    public float MoveSpeed = 1.0f;

    /// <summary>
    /// スピードを計算してくれるメソッド
    /// </summary>
    /// <returns></returns>
    public float CulcSpeed()
    {
        return MoveSpeed * Time.deltaTime;
    }

    public bool CanMove = true;


    /// <summary>
    /// void型は何も返さなくていい処理を書く時に使用します
    /// 今回はDebug.Logに"HelloWorld!"と出力する
    /// </summary>
    public void HelloWorld()
    {
        Debug.Log(helloWorld);
    }
    // このclass(コンポーネント)が追加された
    // GameObjectがHierarchy欄でアクティブになっている場合、
    // 一度だけ実行されるメソッド(処理)です。
    
    // Update is called once per frame
    // このclass(コンポーネント)が追加されたGameObjectが
    // Hierarchy欄でアクティブになっている場合、
    // 毎フレーム実行されるメソッド（処理）です。
    // 毎フレームなので、PC君のCUPの処理速度によって
    // 実行回数が変わってきます。
    void Update()
    {
        HelloWorld();
        // 横方向への自動移動を実装していきます。
        // Time.deltaTimeは前のフレームが終了してから
        // 現在のフレームが開始するまでの時間です。
        // 実際には0.016秒などの値が入ります。
        // この値を掛け算することで、各実行環境で1秒を
        // しっかり定量化できます。 
        // 自分の位置情報に対して、
        // x軸に加算させ続ける実装を行っていきます。
        if (CanMove)
        {
            transform.position +=
                new Vector3(CulcSpeed(), 0, 0);
        }

    }
}

