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
			ImprovedFeedbackPlayer pep = player.GetModPlayer<ImprovedFeedbackPlayer>();
			if (ImprovedFeedbackConfigClient.Instance.itemRustleClothLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleClothLight = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRustleClothMediumWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleClothMedium = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRustleClothHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleClothHeavy = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRustleRattleLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleRattleLight = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRustleRattleHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleRattleHeavy = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemRustleAramidHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleAramidHeavy = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepRubberFlipflopWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepRubberFlipflop = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepLeatherBootLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepLeatherBootLight = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepLeatherBootMediumWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepLeatherBootMedium = true;
			}
			if (ImprovedFeedbackConfigClient.Instance.itemStepLeatherBootHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepLeatherBootHeavy = true;
			}
		}
    }
}