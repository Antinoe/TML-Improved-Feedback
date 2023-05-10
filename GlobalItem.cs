using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace ImprovedFeedback
{
    public class ImprovedFeedbackGlobalItem : GlobalItem
    {
		//public override void UpdateAccessory(Item item, Player player, bool hideVisual)
		public override void UpdateEquip(Item item, Player player)
		{
			ImprovedFeedbackPlayer ifp = player.GetModPlayer<ImprovedFeedbackPlayer>();
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemRustleClothLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRustleClothLight = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemRustleClothMediumWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRustleClothMedium = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemRustleClothHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRustleClothHeavy = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemRattleLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRattleLight = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemRattleHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRattleHeavy = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemRustleAramidHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRustleAramidHeavy = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemStepSandalGTA5Whitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepSandalGTA5 = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemStepBootGTA5Whitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepBootGTA5 = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemStepPraetorSuitDOOM2016Whitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepPraetorSuitDOOM2016 = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemStepMjolnirArmorHalo5Whitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepMjolnirArmorHalo5 = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemStepPowerSuitSuperMetroidWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepPowerSuitSuperMetroid = true;
			}
			if (ImprovedFeedbackConfigClientDeveloper.Instance.itemStepFusionSuitMetroidFusionWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepFusionSuitMetroidFusion = true;
			}
		}
    }
}
