using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace ImprovedFeedback
{
    public class ImprovedFeedbackGlobalItem : GlobalItem
    {
		//public override void UpdateAccessory(Item item, Player player, bool hideVisual)
		public override void UpdateEquip(Item item, Player player)
		{
			ImprovedFeedbackPlayer ifp = player.GetModPlayer<ImprovedFeedbackPlayer>();
			if (ImprovedFeedbackConfigClient.Instance.itemRustleClothLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRustleClothLight = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRustleClothMediumWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRustleClothMedium = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRustleClothHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRustleClothHeavy = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRattleLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRattleLight = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRattleHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRattleHeavy = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRustleAramidHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemRustleAramidHeavy = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepSandalGTA5Whitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepSandalGTA5 = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepBootGTA5Whitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepBootGTA5 = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepPraetorSuitDOOM2016Whitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepPraetorSuitDOOM2016 = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepMjolnirArmorHalo5Whitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepMjolnirArmorHalo5 = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepPowerSuitSuperMetroidWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepPowerSuitSuperMetroid = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepFusionSuitMetroidFusionWhitelist.Contains(new ItemDefinition(item.type)))
			{
				ifp.itemStepFusionSuitMetroidFusion = true;
			}
		}
    }
}
