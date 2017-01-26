using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Temere.Items.Weapons
{
    public class ObsidianBullet : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Obsidian Bullet";
            item.damage = 14;
            item.ranged = true;
            // item.width
            // item.height
            item.maxStack = 999;
            item.toolTip = "Burn, baby, burn";
            item.consumable = true;
            item.knockBack = 2;
            item.value = 20;
            item.rare = 2;
            item.shoot = mod.ProjectileType("ObsidianBullet");
            item.shootSpeed = 15f;
            item.ammo = ProjectileID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Obsidian, 3);
            recipe.AddIngredient(ItemID.MusketBall, 75);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 75);
            recipe.AddRecipe();
        }
    }
}
