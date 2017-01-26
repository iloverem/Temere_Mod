using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Temere.Projectiles
{
    public class FeatherKnifeProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Feather knife";
            // projectile.width = ;
            // projectile.height = ;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = 500;
            projectile.timeLeft = 500;
            projectile.tileCollide = true;
            projectile.aiStyle = ProjectileID.ThrowingKnife;
            aiType = 2;
            projectile.knockBack = 0;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            projectile.velocity *= 0.2f;
        }
    }
}
