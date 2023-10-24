using UnityEngine;
using UnityEngine.UI;

public class GemManager : MonoBehaviour
{
    public static GemManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public int Gold = 0;
    public int Diamond = 0;

    [SerializeField] private Text _goldText;
    [SerializeField] private Text _diamondText;

    private void Start()
    {
        _goldText.text = Gold.ToString();
        _diamondText.text = Diamond.ToString();
    }

    public void IncreaseGold(int value)
    {
        Gold += value;
        _goldText.text = Gold.ToString();
    }

    public void IncreaseDiamond(int value)
    {
        Diamond += value;
        _diamondText.text = Diamond.ToString();
    }

    public void RewardedGold()
    {
        AdsManager.Instance.rewardedStateCount = 0;
        AdsManager.Instance.ShowRewardedAd();
    }

    public void RewardedDiamond()
    {
        AdsManager.Instance.rewardedStateCount = 1;
        AdsManager.Instance.ShowRewardedAd();
    }

    public void OpenFreeCharacter()
    {
        AdsManager.Instance.rewardedStateCount = 2;
        AdsManager.Instance.ShowRewardedAd();
    }
}
