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

namespace PlayerEffects
{
    public class PlayerEffectsGlobalItem : GlobalItem
    {
		//public override void UpdateAccessory(Item item, Player player, bool hideVisual)
		public override void UpdateEquip(Item item, Player player)
		{
			PlayerEffectsPlayer pep = player.GetModPlayer<PlayerEffectsPlayer>();
			if (PlayerEffectsConfigClient.Instance.itemRustleClothLightWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleClothLight = true;
			}
			if (PlayerEffectsConfigClient.Instance.itemRustleClothMediumWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleClothMedium = true;
			}
			if (PlayerEffectsConfigClient.Instance.itemRustleClothHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleClothHeavy = true;
			}
			if (PlayerEffectsConfigClient.Instance.itemRustleAramidHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemRustleAramidHeavy = true;
			}
			if (PlayerEffectsConfigClient.Instance.itemStepLeatherBootMediumWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepLeatherBootMedium = true;
			}
			if (PlayerEffectsConfigClient.Instance.itemStepLeatherBootHeavyWhitelist.Contains(new ItemDefinition(item.type)))
			{
				pep.itemStepLeatherBootHeavy = true;
			}
		}
    }
}