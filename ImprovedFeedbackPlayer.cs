using System; //This is so Math functions can work.
using Microsoft.Xna.Framework;
using Terraria;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Graphics.CameraModifiers;
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
			
			/*if (Player.wet)
			{
				Main.NewText("You are wet.");
			}*/
			
			if (!Player.mount.Active)
			{
				//Stepping
				if (Player.legFrame.Y == Player.legFrame.Height * ImprovedFeedbackConfigClientDeveloper.Instance.footStepLeft || Player.legFrame.Y == Player.legFrame.Height * ImprovedFeedbackConfigClientDeveloper.Instance.footStepRight)
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
			
			if (ImprovedFeedbackConfigClientBasic.Instance.enableSounds && ImprovedFeedbackConfigClientBasic.Instance.enableStepSounds)
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
			
			if (ImprovedFeedbackConfigClientBasic.Instance.enableSounds && ImprovedFeedbackConfigClientBasic.Instance.enableSkidSounds)
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
			
			if (ImprovedFeedbackConfigClientBasic.Instance.enableSounds && ImprovedFeedbackConfigClientBasic.Instance.enableJumpSounds)
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
			
			if (ImprovedFeedbackConfigClientBasic.Instance.enableFallingEffect)
			{
				if (ImprovedFeedbackConfigClientBasic.Instance.enableScreenshake)
				{
					PunchCameraModifier modifier = new PunchCameraModifier(Main.LocalPlayer.Center, (Main.rand.NextFloat() * (MathHelper.TwoPi)).ToRotationVector2(), 1f, 6f, 20, 1000f, FullName);
					Main.instance.CameraModifiers.Add(modifier);
				}
			}
		}
		public void OnLand()
		{
			var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			
			if (ImprovedFeedbackConfigClientBasic.Instance.enableSounds && ImprovedFeedbackConfigClientBasic.Instance.enableLandSounds)
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
			if (ImprovedFeedbackConfigClientBasic.Instance.enableLandingEffect)
			{
				if (ImprovedFeedbackConfigClientBasic.Instance.enableScreenshake)
				{
					PunchCameraModifier modifier = new PunchCameraModifier(Main.LocalPlayer.Center, (Main.rand.NextFloat() * (MathHelper.TwoPi)).ToRotationVector2(), 1f, 10f, 10, 1000f, FullName);
					Main.instance.CameraModifiers.Add(modifier);
				}
			}
		}
		
		public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource, ref int cooldownCounter)
		{
			if (ImprovedFeedbackConfigClientBasic.Instance.enableDynamicDamageEffects)
			{
				playSound = false;
			}
			return true;
		}
		public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit, int cooldownCounter)
		{
			if (ImprovedFeedbackConfigClientBasic.Instance.enableDynamicDamageEffects)
			{
				//if (damage == (int)(Player.statLifeMax * 0.25))
				if (damage > 0 && damage < 5)
				{
					SoundEngine.PlaySound(Sounds.Player.HitWeak, Player.position);
					if (ImprovedFeedbackConfigClientBasic.Instance.enableDamageEffect && ImprovedFeedbackConfigClientBasic.Instance.enableScreenshake)
					{
						PunchCameraModifier modifier = new PunchCameraModifier(Main.LocalPlayer.Center, (Main.rand.NextFloat() * (MathHelper.TwoPi)).ToRotationVector2(), 5f, 5f, 30, 1000f, FullName);
						Main.instance.CameraModifiers.Add(modifier);
					}
				}
				//if (damage == (int)(Player.statLifeMax * 0.50))
				if (damage >= 5 && damage < 15)
				{
					SoundEngine.PlaySound(Sounds.Player.HitModerate, Player.position);
					if (ImprovedFeedbackConfigClientBasic.Instance.enableDamageEffect && ImprovedFeedbackConfigClientBasic.Instance.enableScreenshake)
					{
						PunchCameraModifier modifier = new PunchCameraModifier(Main.LocalPlayer.Center, (Main.rand.NextFloat() * (MathHelper.TwoPi)).ToRotationVector2(), 10f, 5f, 60, 1000f, FullName);
						Main.instance.CameraModifiers.Add(modifier);
					}
				}
				//if (damage == (int)(Player.statLifeMax * 0.75))
				if (damage >= 15)
				{
					SoundEngine.PlaySound(Sounds.Player.HitHard, Player.position);
					if (ImprovedFeedbackConfigClientBasic.Instance.enableDamageEffect && ImprovedFeedbackConfigClientBasic.Instance.enableScreenshake)
					{
						PunchCameraModifier modifier = new PunchCameraModifier(Main.LocalPlayer.Center, (Main.rand.NextFloat() * (MathHelper.TwoPi)).ToRotationVector2(), 15f, 5f, 120, 1000f, FullName);
						Main.instance.CameraModifiers.Add(modifier);
					}
				}
			}
		}
    }
}
