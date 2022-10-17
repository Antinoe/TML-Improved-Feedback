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

namespace ImprovedEffects
{
    public class ImprovedEffectsGlobalItem : GlobalItem
    {
		//public override void UpdateAccessory(Item item, Player player, bool hideVisual)
		public override void UpdateEquip(Item item, Player player)
		{
			ImprovedEffectsPlayer pep = player.GetModPlayer<ImprovedEffectsPlayer>();
			if (ImprovedEffectsConfigClient.Instance.itemRustleClothLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleClothLight = true;
			}
			if (ImprovedEffectsConfigClient.Instance.itemRustleClothMediumWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleClothMedium = true;
			}
			if (ImprovedEffectsConfigClient.Instance.itemRustleClothHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleClothHeavy = true;
			}
			if (ImprovedEffectsConfigClient.Instance.itemRustleRattleLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleRattleLight = true;
			}
			if (ImprovedEffectsConfigClient.Instance.itemRustleRattleHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleRattleHeavy = true;
			}
			if (ImprovedEffectsConfigClient.Instance.itemRustleAramidHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleAramidHeavy = true;
			}
			if (ImprovedEffectsConfigClient.Instance.itemStepRubberFlipflopWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepRubberFlipflop = true;
			}
			if (ImprovedEffectsConfigClient.Instance.itemStepLeatherBootLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepLeatherBootLight = true;
			}
			if (ImprovedEffectsConfigClient.Instance.itemStepLeatherBootMediumWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepLeatherBootMedium = true;
			}
			if (ImprovedEffectsConfigClient.Instance.itemStepLeatherBootHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepLeatherBootHeavy = true;
			}
		}
    }
}