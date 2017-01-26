using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Temere.Items.Weapons
{
    public class Fishtol : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Fishtol";
            item.damage = 20;
            item.ranged = true;
            item.width = 40;
            item.height = 26;
            item.toolTip = "Half fish, half pistol, pretty cool!";
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.noMelee = true; 
            item.knockBack = 7;
            item.value = 1500;
            item.rare = 2;
            item.useSound = 11;
            item.autoReuse = false;
            item.shoot = 10; 
            item.shootSpeed = 10f;
            item.useAmmo = ProjectileID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ShadowScale, 10);
            recipe.AddIngredient(ItemID.DemoniteBar, 7);
            recipe.AddIngredient(ItemID.Goldfish, 1);
            recipe.AddIngredient(ItemID.FlintlockPistol, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
