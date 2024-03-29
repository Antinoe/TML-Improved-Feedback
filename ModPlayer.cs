using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.CameraModifiers;
using Terraria.Audio;
using Terraria.ModLoader;

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
		
		PunchCameraModifier shakeBrittle => new PunchCameraModifier(Main.LocalPlayer.Center, (Main.rand.NextFloat() * (MathHelper.TwoPi)).ToRotationVector2(), 1f, 6f, 10, 15f, "shakeBrittle");
		PunchCameraModifier shakeWeak => new PunchCameraModifier(Main.LocalPlayer.Center, (Main.rand.NextFloat() * (MathHelper.TwoPi)).ToRotationVector2(), 1f, 6f, 10, 15f, "shakeWeak");
		PunchCameraModifier shakeModerate => new PunchCameraModifier(Main.LocalPlayer.Center, (Main.rand.NextFloat() * (MathHelper.TwoPi)).ToRotationVector2(), 1f, 6f, 10, 15f, "shakeModerate");
		PunchCameraModifier shakeStrong => new PunchCameraModifier(Main.LocalPlayer.Center, (Main.rand.NextFloat() * (MathHelper.TwoPi)).ToRotationVector2(), 1f, 6f, 10, 15f, "shakeStrong");
		
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
			//var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			var ifp = this;
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
			//var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			var ifp = this;
			
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
			//var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			var ifp = this;
			
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
			//var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			var ifp = this;
			
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
			//var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			var ifp = this;
			
			if (ImprovedFeedbackConfigClientBasic.Instance.enableFallingEffect)
			{
				if (ImprovedFeedbackConfigClientBasic.Instance.enableScreenshake)
				{
					Main.instance.CameraModifiers.Add(shakeBrittle);
					//Main.NewText("Very Weak Screenshake");
				}
			}
		}
		public void OnLand()
		{
			//var ifp = Main.LocalPlayer.GetModPlayer<ImprovedFeedbackPlayer>();
			var ifp = this;
			
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
					Main.instance.CameraModifiers.Add(shakeWeak);
					//Main.NewText("Weak Screenshake");
				}
			}
		}
		
		public override void OnHurt(Player.HurtInfo info)
		{
			var damage = info.Damage;
			if (ImprovedFeedbackConfigClientBasic.Instance.enableDynamicDamageEffects)
			{
				info.SoundDisabled = true;
				//if (Damage == (int)(Player.statLifeMax * 0.25))
				if (damage > 0 && damage < 5)
				{
					SoundEngine.PlaySound(Sounds.Player.HitWeak, Player.position);
					if (ImprovedFeedbackConfigClientBasic.Instance.enableDamageEffect && ImprovedFeedbackConfigClientBasic.Instance.enableScreenshake)
					{
						Main.instance.CameraModifiers.Add(shakeWeak);
						//Main.NewText("Weak Screenshake");
					}
				}
				//if (Damage == (int)(Player.statLifeMax * 0.50))
				if (damage >= 5 && damage < 15)
				{
					SoundEngine.PlaySound(Sounds.Player.HitModerate, Player.position);
					if (ImprovedFeedbackConfigClientBasic.Instance.enableDamageEffect && ImprovedFeedbackConfigClientBasic.Instance.enableScreenshake)
					{
						Main.instance.CameraModifiers.Add(shakeModerate);
						//Main.NewText("Moderate Screenshake");
					}
				}
				//if (Damage == (int)(Player.statLifeMax * 0.75))
				if (damage >= 15)
				{
					SoundEngine.PlaySound(Sounds.Player.HitHard, Player.position);
					if (ImprovedFeedbackConfigClientBasic.Instance.enableDamageEffect && ImprovedFeedbackConfigClientBasic.Instance.enableScreenshake)
					{
						Main.instance.CameraModifiers.Add(shakeStrong);
						//Main.NewText("Strong Screenshake");
					}
				}
			}
		}
        public override void ModifyHurt(ref Player.HurtModifiers modifiers)
        {
			if (ImprovedFeedbackConfigClientBasic.Instance.enableDynamicDamageEffects)
			{
				modifiers.DisableSound();
			}
        }
    }
}