using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Temere.Items.Weapons
{
    public class Lucidity : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Lucidity";
            item.damage = 10;
            item.ranged = true;
            // item.width = ;
            // item.height = ;
            item.toolTip = "Balance and control";
            item.useTime = 20; 
            item.useAnimation = 20;
            item.noMelee = true;
            item.shoot = 10;
            item.useStyle = 5;
            item.knockBack = 1;
            item.value = 470;
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = false;
            item.useAmmo = ProjectileID.WoodenArrowFriendly;//need to find the projectile type for arrow
            item.shootSpeed = 20f; 
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("NightmareBar", 8);
            recipe.AddIngredient(ItemID.SilverBow, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
