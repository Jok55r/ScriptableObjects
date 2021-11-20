using UnityEngine;
using UnityEngine.UI;

public class SwordMerchant : MonoBehaviour
{
	public Text swordName;
	public Text description;
	public Image icon;
	public Text goldCost;
	public Text attackDamage;

	SwordData swordData;

	public void UpdateDisplayUI()
	{
		swordName.text = swordData.swordName;
		description.text = swordData.description;
		icon.sprite = swordData.icon;
		goldCost.text = swordData.goldCost.ToString();
		attackDamage.text = swordData.attackDamage.ToString();
	}
}
