using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Temere.Items.Weapons
{
    public class GlowingMushroomBow : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Glowing Mushroom Bow";
            item.damage = 7;
            item.ranged = true;
           // item.width = ;
           // item.height = ;
            item.useTime = 25;
            item.useAnimation = 25;
            item.noMelee = true;
            item.shoot = 10;
            item.useStyle = 5;
            item.knockBack = 1;
            item.value = 60;
            item.rare = 0;
            item.useSound = 1;
            item.autoReuse = false;
            item.useAmmo = ProjectileID.WoodenArrowFriendly;
            item.shootSpeed = 6f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GlowingMushroom, 11);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
