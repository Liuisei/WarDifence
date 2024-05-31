using UnityEngine;
using UnityEngine.UI;

public class SetUpStage : MonoBehaviour
{
    [SerializeField] private GameObject _stage; //StageUI
    [SerializeField] private Text _stageLevelText; //Stageのlevelを表示するtext
    [SerializeField] private Text _getCoinText;
    
    private int _getCoin; //獲得したCoinの数　ToDo：DataManagerのCoinを取得する

    //Game開始時にステージを配置する
    //GameManagerが呼び出す
    private void SetUpStageUI(int StageLevel)
    {
        _stage.SetActive(true);
        //DataManagerに保存してあるStageLevelを参照する
        _stageLevelText.text = "ステージ"　+ StageLevel;
        _getCoinText.text = "Coin" + _getCoin;
    }
}
