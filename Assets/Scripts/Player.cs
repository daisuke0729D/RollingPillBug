using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //スクリプトの書き方
    //例えばplayertransform.positionのドットは「の」と言い換えることができます。
    //playerTransformのpositonという翻訳文になります。
    //そしてplayerTransformのセミコロンは句読点である「。」に当たります。

    /// <summary>
    /// プレイヤーの位置
    /// </summary>
    public Transform playerTransform;
  

    // Update is called once per frame
    void Update()
    {
        //もし水平方向の入力が０じゃなかった場合
        if (Input.GetAxis("Horizontal") != 0)
        {
            //playerのTransformのpositionに水平方向の入力の値を加算する
            playerTransform.position +=
                   new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        }

    }
}

