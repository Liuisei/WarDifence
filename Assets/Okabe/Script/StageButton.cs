using UnityEngine;
using UnityEngine.UI;

public class StageButton : MonoBehaviour
{
    [SerializeField] private short _stageLevel;
    [SerializeField] private Text _stageLevelText;

    public short SelectStageLevel => _stageLevel;

    private void Start()
    {
        _stageLevelText.text = "Stage " + _stageLevel;
    }
}