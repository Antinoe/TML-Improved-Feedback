using System; //This is so Math functions can work.
using Microsoft.Xna.Framework;
using Terraria;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.Mount;

namespace ImprovedFeedback
{
    public class ImprovedFeedbackPlayer : ModPlayer
    {
		public bool stepping;
		public bool skidding;
		public bool inAir;
		public bool jumping;
		public bool landing;
		public bool itemRustleClothLight;
		public bool itemRustleClothMedium;
		public bool itemRustleClothHeavy;
		public bool itemRattleLight;
		public bool itemRattleHeavy;
		public bool itemRustleAramidHeavy;
		public bool itemStepSandalGTA5;
		public bool itemStepBootGTA5;
		public bool itemStepPowerSuitSuperMetroid;
		public bool itemStepFusionSuitMetroidFusion;
		public bool itemStepPraetorSuitDOOM2016;
		public bool itemStepMjolnirArmorHalo5;
		public bool hasFootwear;
		public int screenShakeTimerVeryWeak;
		public int screenShakeTimerWeak;
		public int screenShakeTimerModerate;
		public int screenShakeTimerStrong;
		
        public override void ResetEffects()
        {
			itemRustleClothLight = false;
			itemRustleClothMedium = false;
			itemRustleClothHeavy = false;
			itemRattleLight = false;
			itemRattleHeavy = false;
			itemRustleAramidHeavy = false;
			itemStepSandalGTA5 = false;
			itemStepBootGTA5 = false;
			itemStepPowerSuitSuperMetroid = false;
			itemStepFusionSuitMetroidFusion = false;
			itemStepPraetorSuitDOOM2016 = false;
			itemStepMjolnirArmorHalo5 = false;
			hasFootwear = false;
        }
		
		public override void PostUpdateMiscEffects()
		{
			//var Player = Main.LocalPlayer;
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			hasFootwear = (itemStepSandalGTA5 || itemStepBootGTA5 || itemStepPowerSuitSuperMetroid || itemStepFusionSuitMetroidFusion || itemStepPraetorSuitDOOM2016 || itemStepMjolnirArmorHalo5);
			
			if (screenShakeTimerVeryWeak > 0)
			{
				screenShakeTimerVeryWeak--;
			}
			if (screenShakeTimerWeak > 0)
			{
				screenShakeTimerWeak--;
			}
			if (screenShakeTimerModerate > 0)
			{
				screenShakeTimerModerate--;
			}
			if (screenShakeTimerStrong > 0)
			{
				screenShakeTimerStrong--;
			}
			
			if (!Player.mount.Active)
			{
				//Stepping
				if (Player.legFrame.Y == Player.legFrame.Height * 9 || Player.legFrame.Y == Player.legFrame.Height * 16)
				{
					if (!stepping)
					{
						stepping = true;
						OnStep();
					}
				}
				else
				{
					stepping = false;
				}
				//Skidding
				if (Player.velocity.X == 0 && Player.velocity.Y == 0)
				{
					if (!skidding)
					{
						skidding = true;
						OnSkid();
					}
				}
				else
				{
					skidding = false;
				}
				//Jumping
				if (Player.velocity.Y < 0 && Player.controlJump)
				{
					if (!jumping)
					{
						jumping = true;
						OnJump();
					}
				}
				else
				{
					jumping = false;
				}
				//Falling
				if (Player.velocity.Y > 10)
				{
					OnFalling();
				}
				//Landing
				if (Player.velocity.Y == 0)
				{
					if (!landing)
					{
						landing = true;
						OnLand();
					}
				}
				else
				{
					landing = false;
				}
			}
		}
		
		/*
		//	Actions called from PostUpdateMiscEffects.
		*/
		
		public void OnStep()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableSounds)
			{
				//I'm well aware of how unoptimized this file is. I'll fix it soon.
				if (!ifp.hasFootwear)
				{
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
				}
				else
				{
					if (ifp.itemStepSandalGTA5)
					{
						SoundEngine.PlaySound(Sounds.Player.StepSandalGTA5, Player.position);
					}
					if (ifp.itemStepBootGTA5)
					{
						SoundEngine.PlaySound(Sounds.Player.StepBootGTA5, Player.position);
					}
					if (ifp.itemStepPowerSuitSuperMetroid)
					{
						SoundEngine.PlaySound(Sounds.Player.StepPowerSuitSuperMetroid, Player.position);
					}
					if (ifp.itemStepFusionSuitMetroidFusion)
					{
						SoundEngine.PlaySound(Sounds.Player.StepFusionSuitMetroidFusion, Player.position);
					}
					if (ifp.itemStepPraetorSuitDOOM2016)
					{
						SoundEngine.PlaySound(Sounds.Player.StepPraetorSuitDOOM2016, Player.position);
					}
					if (ifp.itemStepMjolnirArmorHalo5)
					{
						SoundEngine.PlaySound(Sounds.Player.StepMjolnirArmorHalo5, Player.position);
					}
				}
				if (ifp.itemRustleClothLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothLight, Player.position);
				}
				if (ifp.itemRustleClothMedium)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothMedium, Player.position);
				}
				if (ifp.itemRustleClothHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothHeavy, Player.position);
				}
				if (ifp.itemRattleLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RattleLight, Player.position);
				}
				if (ifp.itemRattleHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RattleHeavy, Player.position);
				}
				if (ifp.itemRustleAramidHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleAramidHeavy, Player.position);
				}
			}
		}
		public void OnSkid()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableSounds)
			{
				if (!ifp.hasFootwear)
				{
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
				}
				else
				{
					SoundEngine.PlaySound(Sounds.Player.Skid, Player.position);
				}
			}
		}
		public void OnJump()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableSounds)
			{
				if (!ifp.hasFootwear)
				{
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
				}
				else
				{
					if (ifp.itemStepSandalGTA5)
					{
						SoundEngine.PlaySound(Sounds.Player.StepSandalGTA5, Player.position);
					}
					if (ifp.itemStepBootGTA5)
					{
						SoundEngine.PlaySound(Sounds.Player.LandBootGTA5, Player.position);
					}
					if (ifp.itemStepFusionSuitMetroidFusion)
					{
						SoundEngine.PlaySound(Sounds.Player.JumpFusionSuitMetroidFusion, Player.position);
					}
					if (ifp.itemStepPraetorSuitDOOM2016)
					{
						SoundEngine.PlaySound(Sounds.Player.JumpPraetorSuitDOOM2016, Player.position);
					}
					if (ifp.itemStepMjolnirArmorHalo5)
					{
						SoundEngine.PlaySound(Sounds.Player.LandMjolnirArmorHalo5, Player.position);
					}
				}
				if (ifp.itemRustleClothLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothLight, Player.position);
				}
				if (ifp.itemRustleClothMedium)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothMedium, Player.position);
				}
				if (ifp.itemRustleClothHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothHeavy, Player.position);
				}
				if (ifp.itemRattleLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RattleLight, Player.position);
				}
				if (ifp.itemRattleHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RattleHeavy, Player.position);
				}
				if (ifp.itemRustleAramidHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleAramidHeavy, Player.position);
				}
			}
		}
		public void OnFalling()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)
			{
				screenShakeTimerWeak = 5;
			}
		}
		public void OnLand()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClient.Instance.enableSounds)
			{
				if (!ifp.hasFootwear)
				{
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
					SoundEngine.PlaySound(Sounds.Player.Step, Player.position);
				}
				else
				{
					if (ifp.itemStepSandalGTA5)
					{
						SoundEngine.PlaySound(Sounds.Player.StepSandalGTA5, Player.position);
						SoundEngine.PlaySound(Sounds.Player.StepSandalGTA5, Player.position);
					}
					if (ifp.itemStepBootGTA5)
					{
						SoundEngine.PlaySound(Sounds.Player.LandBootGTA5, Player.position);
					}
					if (ifp.itemStepPowerSuitSuperMetroid)
					{
						SoundEngine.PlaySound(Sounds.Player.LandPowerSuitSuperMetroid, Player.position);
					}
					if (ifp.itemStepFusionSuitMetroidFusion)
					{
						SoundEngine.PlaySound(Sounds.Player.LandFusionSuitMetroidFusion, Player.position);
					}
					if (ifp.itemStepPraetorSuitDOOM2016)
					{
						SoundEngine.PlaySound(Sounds.Player.LandPraetorSuitDOOM2016, Player.position);
					}
					if (ifp.itemStepMjolnirArmorHalo5)
					{
						SoundEngine.PlaySound(Sounds.Player.LandMjolnirArmorHalo5, Player.position);
						SoundEngine.PlaySound(Sounds.Player.LandMjolnirArmorHalo5, Player.position);
					}
				}
				if (ifp.itemRustleClothLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothLight, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleClothLight, Player.position);
				}
				if (ifp.itemRustleClothMedium)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothMedium, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleClothMedium, Player.position);
				}
				if (ifp.itemRustleClothHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleClothHeavy, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleClothHeavy, Player.position);
				}
				if (ifp.itemRattleLight)
				{
					SoundEngine.PlaySound(Sounds.Player.RattleLight, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RattleLight, Player.position);
				}
				if (ifp.itemRattleHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RattleHeavy, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RattleHeavy, Player.position);
				}
				if (ifp.itemRustleAramidHeavy)
				{
					SoundEngine.PlaySound(Sounds.Player.RustleAramidHeavy, Player.position);
					SoundEngine.PlaySound(Sounds.Player.RustleAramidHeavy, Player.position);
				}
			}
			if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)
			{
				screenShakeTimerVeryWeak = 10;
			}
		}
		
		public override void ModifyScreenPosition()
		{
            if (screenShakeTimerVeryWeak > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.10f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.10f);
            }
            if (screenShakeTimerWeak > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.50f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 1.50f);
            }
            if (screenShakeTimerModerate > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 2.00f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 2.00f);
            }
            if (screenShakeTimerStrong > 0)
            {
				Main.screenPosition.X += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 4.00f);
				Main.screenPosition.Y += (float)Math.Round(Main.rand.Next((int)(0f - 1), (int)1) * 4.00f);
            }
		}
		
		public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource, ref int cooldownCounter)
		{
			if (ImprovedFeedbackConfigClient.Instance.enableDynamicDamageEffects)
			{
				playSound = false;
			}
			return true;
		}
		public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit, int cooldownCounter)
		{
			if (ImprovedFeedbackConfigClient.Instance.enableDynamicDamageEffects)
			{
				//if (damage == (int)(Player.statLifeMax * 0.25))
				if (damage > 0 && damage < 5)
				{
					SoundEngine.PlaySound(Sounds.Player.HitWeak, Player.position);
					if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)	{screenShakeTimerWeak = 10;}
				}
				//if (damage == (int)(Player.statLifeMax * 0.50))
				if (damage >= 5 && damage < 15)
				{
					SoundEngine.PlaySound(Sounds.Player.HitModerate, Player.position);
					if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)	{screenShakeTimerModerate = 15;}
				}
				//if (damage == (int)(Player.statLifeMax * 0.75))
				if (damage >= 15)
				{
					SoundEngine.PlaySound(Sounds.Player.HitHard, Player.position);
					if (ImprovedFeedbackConfigClient.Instance.enableScreenshake)	{screenShakeTimerStrong = 20;}
				}
			}
		}
    }
}
