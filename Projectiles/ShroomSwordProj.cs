using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Temere.Projectiles
{
    public class ShroomSwordProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Shroom Cloud";
            projectile.width = 30;
            projectile.height = 30;
            projectile.aiStyle = 44;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = 50;
            projectile.timeLeft = 1000;
            projectile.light = 0.5f;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.SporeCloud;
            projectile.tileCollide = false;
        }
        public override void AI()
        {
            projectile.rotation += 0.07f;
        }
    }
}
